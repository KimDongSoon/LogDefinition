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
    public partial class LogTypeEditor : Form
    {
        class Log : LogTypeEditor
        {
            private string LogName = string.Empty;
            private string Type = string.Empty;
            private string Title = string.Empty;
            private string LogType = string.Empty;
            private string AdditionalProperties = string.Empty;

        }

        public LogTypeEditor()
        {
            InitializeComponent();
        }

        private void btn_AddLog_Click(object sender, EventArgs e)
        {
            Log logData = new Log();

            

            //List<string> addLogData = new List<string>();
            //addLogData.Add(tb_LogName.Text);
        }
    }
}
