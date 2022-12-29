using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LogDefinition_1
{
    public partial class LogFieldEditor : Form
    {
        int index = 0;

        bool isLogDefine = false; // true : 로그정의서 json에 저장, false : LogCommon json에 저장

        //JObject[] arrayJObjects = new JObject[];

        DataTable dtFieldFactors = new DataTable();

        public LogFieldEditor(string logName)
        {
            InitializeComponent();

            dtFieldFactors.Columns.Add("하위필드");
            dtFieldFactors.Columns.Add("값");

            tb_LogFieldName.Text = logName;
        }

        public void LogFieldEditor_Load(object sender, EventArgs e)
        {
            DataTable lowerLogFieldList = sender as DataTable;

            Form1 frm_Main = new Form1();
            frm_Main.dataSendEvent += new NewLogFieldNameGetEventHandler(this.GetLogFieldName);

            cb_FieldType.Items.Clear();

            if (lowerLogFieldList != null)
            {
                for (int i = 0; i < lowerLogFieldList.Rows.Count; ++i)
                {
                    cb_FieldType.Items.Add(lowerLogFieldList.Rows[i]["LowerLogField"]);
                }
            } 
        }

        private void GetLogFieldName(string data)
        {
            tb_LogFieldName.Text = data;
        }

        private void btn_AddLogField_Click(object sender, EventArgs e)
        {
            dtFieldFactors.Rows.Add(cb_FieldType.Text);

            dgv_FieldFactors.DataSource = dtFieldFactors;
        }

        private void btn_SaveToCommon_Click(object sender, EventArgs e)
        {
            //DataTableToJToken(arrayJObjects);

        }


        private void DataTableToJToken(JObject[] jobject)
        {
            var item = new JObject();

            for (int i = 0; i < dtFieldFactors.Rows.Count; ++i)
            {
                item.Add(dtFieldFactors.Rows[i]["하위필드"].ToString(), dtFieldFactors.Rows[i]["값"].ToString());
            }

            //arrayJObjects[arrayJObjects.Length - 1].Add(item);

            //return item;
        }
    }
}
