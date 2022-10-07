using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogDefinition_1
{


    public partial class LogFieldEditor : Form
    {
        public LogFieldEditor()
        {
            InitializeComponent();
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
    }
}
