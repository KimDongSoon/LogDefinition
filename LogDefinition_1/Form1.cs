using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LogDefinition_1
{
    public delegate void NewLogFieldNameGetEventHandler(string name);

    public partial class Form1 : Form
    {
        string jsonFilePath = string.Empty;
        string LogCommonjsonFilePath = string.Empty;

        // Delegate
        public NewLogFieldNameGetEventHandler dataSendEvent;

        //List<string> LogNameList = new List<string>();            // 
        static DataTable dtLogType = new DataTable();             // LogType 리스트가 저장되어있는 리스트
        static DataTable dtLogCommon = new DataTable();           // LogCommon에 정의되어있는 Field 리스트
        static DataTable dtLowerLogFieldList = new DataTable();   // LogField 내부에 type, minimum 등을 저장해놓는 데이터테이블

        DataTable originalLogDetails = new DataTable();
        DataTable logDetails = new DataTable();

        string selectedLogName = string.Empty;

        public Form1()
        {
            jsonFilePath = "C:\\Users\\WM-OD001007\\Desktop\\MADNGINE-LogSchemaDesign_2022-08-28_1\\Log.schema.json";
            LogCommonjsonFilePath = "C:\\Users\\WM-OD001007\\Desktop\\MADNGINE-LogSchemaDesign_2022-08-28_1\\LogCommon.schema.json";

            InitializeComponent();

            ShowTypeList();
            ShowLogCommonList();

            GetLowerLogFieldList();
        }

        private void btn_LoadLogSchema_Click(object sender, EventArgs e)
        {
            string str = string.Empty;

            using (StreamReader file = File.OpenText(jsonFilePath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);

                str = JValue.Parse(json.ToString()).ToString(Formatting.Indented);

                rtxt_LogText.Text = str;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                JObject json = JObject.Parse(rtxt_LogText.Text);

                File.WriteAllText(jsonFilePath, json.ToString());

                MessageBox.Show("저장 성공", "저장 완료");
            }

            catch
            {
                MessageBox.Show("형식을 확인하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowTypeList()
        {
            GetLogKeyList();

            dgv_TypeList.DataSource = dtLogType;
        }

        private void GetLogKeyList()
        {
            string jsonData = File.ReadAllText(jsonFilePath);

            dtLogType = new DataTable();

            dtLogType.Columns.Add("LogName");
            dtLogType.Columns.Add("LogType");
            dtLogType.Columns.Add("Title");

            JObject jobject = JObject.Parse(jsonData);

            JToken jToken = jobject["definitions"];

            // 데이터테이블 dtLogType에 LogName, LogType, Title 삽입
            foreach (JProperty jProperty in jToken)
            {
                JToken logToken = jProperty.Value.ToObject<JToken>();

                dtLogType.Rows.Add(jProperty.Name, logToken["properties"]["Type"]["const"], logToken["title"]);
            }
        }

        private void ShowLogCommonList()
        {
            GetLogCommonList();

            dgv_LogCommon.DataSource = dtLogCommon;
        }

        private void GetLogCommonList()
        {
            string jsonData = File.ReadAllText(LogCommonjsonFilePath);

            dtLogCommon = new DataTable();
            dtLogCommon.Columns.Add("LogCommon");

            JObject jobject = JObject.Parse(jsonData);

            JToken jToken = jobject["definitions"];

            // 데이터테이블 dtLogType에 LogName, LogType, Title 삽입
            foreach (JProperty jProperty in jToken)
            {
                JToken logToken = jProperty.Value.ToObject<JToken>();

                dtLogCommon.Rows.Add(jProperty.Name);
            }
        }

        private void dgv_TypeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_TypeList.CurrentCell.RowIndex;
            selectedLogName = dgv_TypeList.Rows[index].Cells[0].Value.ToString();

            ViewLogDetails(selectedLogName);

        }

        private void ViewLogDetails(string logName)
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            JObject jobject = JObject.Parse(jsonData);

            logDetails = new DataTable();
            logDetails.Columns.Add("Required");

            JToken jToken = jobject["definitions"][logName]["required"];

            foreach (var jProperty in jToken.Select((value, index) => (value, index)))
            {
                var value = jProperty.value;

                logDetails.Rows.Add(value);
            }

            dgv_LogDetail.DataSource = logDetails;

            // 기존 필드 복사 DataTable 생성
            originalLogDetails = logDetails.Copy();
        }

        private void btn_AddLogField_Click(object sender, EventArgs e)
        {
            SaveNewLogField();
        }




        // LogCommon 
        private void cb_LogCommonList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtLogCommon.Rows.Count; ++i)
            {
                cb_LogCommonList.Items.Add(dtLogCommon.Rows[i]["LogCommon"]);
            }
        }

        private void cb_LogCommonList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedField = cb_LogCommonList.SelectedItem.ToString();

            // LogCommon 파일에 존재하는지 확인
            string jsonCommonData = File.ReadAllText(LogCommonjsonFilePath);
            string jsonData = File.ReadAllText(jsonFilePath);

            JObject jObject = JObject.Parse(jsonCommonData);
            JToken jToken = jObject["definitions"][selectedField];

            if (dgv_LogDetail.DataSource == null)
            {
                MessageBox.Show("변경할 로그를 선택하세요", "로그", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // 이미 필드가 존재하는 경우
                if (logDetails.AsEnumerable().Where(c => c.Field<string>("Required").Equals(cb_LogCommonList.SelectedItem.ToString())).Count() > 0)
                {
                    MessageBox.Show("이미 해당 필드가 로그에 존재합니다.", "필드 존재", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 선택된 필드를 DataGridView 및 logDetail 데이터테이블에 추가
                else
                {
                    originalLogDetails = logDetails.Copy();

                    logDetails.Rows.Add(cb_LogCommonList.SelectedItem.ToString());
                }

                // 선택된 필드를 json 파일에 추가 (LogCommon에 정의 되어있는 경우)
                //jObject = JObject.Parse(jsonData);

                //SaveNewLogField();
            }
        }

        private void SaveNewLogField()
        {
            // json 파일 열기
            string jsonData = File.ReadAllText(jsonFilePath);
            JObject jObject = JObject.Parse(jsonData);

            DataTable newFieldList = new DataTable();
            var addedNewFieldList = logDetails.AsEnumerable().Select(r => r.Field<string>("Required")).Except(originalLogDetails.AsEnumerable().Select(r => r.Field<string>("Required")));
            newFieldList = (from row in logDetails.AsEnumerable() join list in addedNewFieldList on row.Field<string>("Required") equals list select row).CopyToDataTable();

            // 중복되는 필드가 있는지 확인, 없으면 추가
            if (newFieldList == null) // originalLogDetails.AsEnumerable().Where(c => c.Field<string>("Required").Equals(cb_LogCommonList.SelectedItem.ToString())).Count() > 0
            {
                MessageBox.Show("이미 해당 필드가 로그에 존재합니다.", "필드 존재", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 중복되는 필드가 없는 경우 로그정의서에 업데이트
            else
            {
                // required에 저장
                JArray logField = (JArray)jObject["definitions"][selectedLogName]["required"];

                for (int i = 0; i < newFieldList.Rows.Count; ++i)
                {
                    logField.Add(newFieldList.Rows[i]["Required"]);
                }

                // properties에 저장
                JToken logCommon = (JToken)jObject["definitions"][selectedLogName]["properties"];

                for (int i = 0; i < newFieldList.Rows.Count; ++i)
                {
                    // Common에 존재하는지 판단
                    bool isExist = CheckLogCommon(newFieldList.Rows[i]["Required"].ToString());

                    // Common에 존재하는 경우
                    if (isExist == true)
                    {
                        //string logCommonRef = string.Empty;
                        //logCommonRef = @"{""$ref"":""LogCommon.schema.json#/definitions/";
                        //logCommonRef += newFieldList.Rows[i]["Required"].ToString();
                        //logCommonRef += @"""}";

                        logCommon[newFieldList.Rows[i]["Required"]] = JObject.Parse(@"{""$ref"":""LogCommon.schema.json#/definitions/" + newFieldList.Rows[i]["Required"].ToString() + @"""}");
                    }

                    // Common에 존재하지 않는 경우
                    else
                    {


                    }

                }

            }

            // json 파일로 저장
            try
            {
                File.WriteAllText(jsonFilePath, jObject.ToString());

                MessageBox.Show("저장 성공", "저장 완료");
            }
            catch
            {
                MessageBox.Show("형식을 확인하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool CheckLogCommon(string logCommon) // Common json 파일에 존재하는 항목인지 판단하는 함수
        {
            bool isExist = true;

            // LogCommon.json 파일 열기
            string jsonData = File.ReadAllText(LogCommonjsonFilePath);
            JObject jObject = JObject.Parse(jsonData);

            JToken jToken = jObject["definitions"][logCommon];

            // Common에 존재하는 경우
            if (jToken != null)
            {
                isExist = true;
            }
            // Common에 존재하지 않는 경우
            else
            {
                isExist = false;
            }

            return isExist;
        }

        private void dgv_LogDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Edit를 한다는 것은 체크박스에 없는 컬럼을 추가하겠다는 얘기니까

            // Log정의서 json 파일에 추가

            // 로그 필드 추가 팝업
            LogFieldEditor frm_LogfieldEditor = new LogFieldEditor();

            // dgv에 추가된 필드를 dt 마지막 Row에 추가시켜 sender로 넘겨줌
            //dtLowerLogFieldList.Rows.Add(dgv_LogDetail.SelectedCells[0].Value.ToString());
            
            frm_LogfieldEditor.Show();
            frm_LogfieldEditor.LogFieldEditor_Load(dtLowerLogFieldList, e);
            dataSendEvent(dgv_LogDetail.SelectedCells[0].Value.ToString());

            // LogCommon json에 추가

        }


        private void GetLowerLogFieldList()
        {
            string jsonData = File.ReadAllText(LogCommonjsonFilePath);
            JObject jObject = JObject.Parse(jsonData);

            dtLowerLogFieldList = new DataTable();
            dtLowerLogFieldList.Columns.Add("LowerLogField");

            for (int i = 0; i < dtLogCommon.Rows.Count; ++i)
            {
                JToken jToken = jObject["definitions"][dtLogCommon.Rows[i]["LogCommon"]];

                // 데이터테이블 dtLogType에 LogName, LogType, Title 삽입 (중복제거 전)
                foreach (JProperty jProperty in jToken)
                {
                    JToken logToken = jProperty.Value.ToObject<JToken>();

                    dtLowerLogFieldList.Rows.Add(jProperty.Name);
                }
            }

            dtLowerLogFieldList = dtLowerLogFieldList.DefaultView.ToTable(true);
        }

        private void newLowerLogField(string argMsg)
        {
            dgv_LogDetail.SelectedCells[0].Value = argMsg;
        }
    }
}
