
namespace LogDefinition_1
{
    partial class LogFieldEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_LogFieldName = new System.Windows.Forms.Label();
            this.tb_LogFieldName = new System.Windows.Forms.TextBox();
            this.btn_SaveToCommon = new System.Windows.Forms.Button();
            this.btn_SaveToLog = new System.Windows.Forms.Button();
            this.cb_FieldType = new System.Windows.Forms.ComboBox();
            this.lb_LowerLogField1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_LogFieldName
            // 
            this.lb_LogFieldName.AutoSize = true;
            this.lb_LogFieldName.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_LogFieldName.Location = new System.Drawing.Point(12, 24);
            this.lb_LogFieldName.Name = "lb_LogFieldName";
            this.lb_LogFieldName.Size = new System.Drawing.Size(54, 15);
            this.lb_LogFieldName.TabIndex = 0;
            this.lb_LogFieldName.Text = "필드 이름";
            // 
            // tb_LogFieldName
            // 
            this.tb_LogFieldName.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_LogFieldName.Location = new System.Drawing.Point(154, 22);
            this.tb_LogFieldName.Name = "tb_LogFieldName";
            this.tb_LogFieldName.ReadOnly = true;
            this.tb_LogFieldName.Size = new System.Drawing.Size(100, 23);
            this.tb_LogFieldName.TabIndex = 1;
            // 
            // btn_SaveToCommon
            // 
            this.btn_SaveToCommon.BackColor = System.Drawing.Color.White;
            this.btn_SaveToCommon.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SaveToCommon.Location = new System.Drawing.Point(14, 412);
            this.btn_SaveToCommon.Name = "btn_SaveToCommon";
            this.btn_SaveToCommon.Size = new System.Drawing.Size(112, 23);
            this.btn_SaveToCommon.TabIndex = 2;
            this.btn_SaveToCommon.Text = "Common에 저장";
            this.btn_SaveToCommon.UseVisualStyleBackColor = false;
            // 
            // btn_SaveToLog
            // 
            this.btn_SaveToLog.BackColor = System.Drawing.Color.White;
            this.btn_SaveToLog.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SaveToLog.Location = new System.Drawing.Point(142, 412);
            this.btn_SaveToLog.Name = "btn_SaveToLog";
            this.btn_SaveToLog.Size = new System.Drawing.Size(112, 23);
            this.btn_SaveToLog.TabIndex = 3;
            this.btn_SaveToLog.Text = "로그정의서에 저장";
            this.btn_SaveToLog.UseVisualStyleBackColor = false;
            // 
            // cb_FieldType
            // 
            this.cb_FieldType.FormattingEnabled = true;
            this.cb_FieldType.Location = new System.Drawing.Point(15, 66);
            this.cb_FieldType.Name = "cb_FieldType";
            this.cb_FieldType.Size = new System.Drawing.Size(121, 20);
            this.cb_FieldType.TabIndex = 4;
            // 
            // lb_LowerLogField1
            // 
            this.lb_LowerLogField1.AutoSize = true;
            this.lb_LowerLogField1.Location = new System.Drawing.Point(14, 109);
            this.lb_LowerLogField1.Name = "lb_LowerLogField1";
            this.lb_LowerLogField1.Size = new System.Drawing.Size(63, 12);
            this.lb_LowerLogField1.TabIndex = 5;
            this.lb_LowerLogField1.Text = "하위필드 1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(154, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LogFieldEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_LowerLogField1);
            this.Controls.Add(this.cb_FieldType);
            this.Controls.Add(this.btn_SaveToLog);
            this.Controls.Add(this.btn_SaveToCommon);
            this.Controls.Add(this.tb_LogFieldName);
            this.Controls.Add(this.lb_LogFieldName);
            this.Name = "LogFieldEditor";
            this.Text = "LogFieldEditor";
            this.Load += new System.EventHandler(this.LogFieldEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LogFieldName;
        private System.Windows.Forms.TextBox tb_LogFieldName;
        private System.Windows.Forms.Button btn_SaveToCommon;
        private System.Windows.Forms.Button btn_SaveToLog;
        private System.Windows.Forms.ComboBox cb_FieldType;
        private System.Windows.Forms.Label lb_LowerLogField1;
        private System.Windows.Forms.Button button1;
    }
}