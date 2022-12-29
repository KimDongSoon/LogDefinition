
namespace LogDefinition_1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LoadLogSchema = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.rtxt_LogText = new System.Windows.Forms.RichTextBox();
            this.dgv_TypeList = new System.Windows.Forms.DataGridView();
            this.dgv_LogDetail = new System.Windows.Forms.DataGridView();
            this.btn_AddLogField = new System.Windows.Forms.Button();
            this.dgv_LogCommon = new System.Windows.Forms.DataGridView();
            this.cb_LogCommonList = new System.Windows.Forms.ComboBox();
            this.btn_SaveLogType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogCommon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadLogSchema
            // 
            this.btn_LoadLogSchema.BackColor = System.Drawing.Color.White;
            this.btn_LoadLogSchema.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_LoadLogSchema.Location = new System.Drawing.Point(13, 13);
            this.btn_LoadLogSchema.Name = "btn_LoadLogSchema";
            this.btn_LoadLogSchema.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadLogSchema.TabIndex = 0;
            this.btn_LoadLogSchema.Text = "불러오기";
            this.btn_LoadLogSchema.UseVisualStyleBackColor = false;
            this.btn_LoadLogSchema.Click += new System.EventHandler(this.btn_LoadLogSchema_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Save.Location = new System.Drawing.Point(94, 13);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "저장하기";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // rtxt_LogText
            // 
            this.rtxt_LogText.Location = new System.Drawing.Point(14, 44);
            this.rtxt_LogText.Name = "rtxt_LogText";
            this.rtxt_LogText.Size = new System.Drawing.Size(155, 395);
            this.rtxt_LogText.TabIndex = 2;
            this.rtxt_LogText.Text = "";
            // 
            // dgv_TypeList
            // 
            this.dgv_TypeList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TypeList.Location = new System.Drawing.Point(175, 45);
            this.dgv_TypeList.Name = "dgv_TypeList";
            this.dgv_TypeList.RowHeadersVisible = false;
            this.dgv_TypeList.RowTemplate.Height = 23;
            this.dgv_TypeList.Size = new System.Drawing.Size(631, 394);
            this.dgv_TypeList.TabIndex = 3;
            this.dgv_TypeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TypeList_CellClick);
            // 
            // dgv_LogDetail
            // 
            this.dgv_LogDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LogDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogDetail.Location = new System.Drawing.Point(958, 45);
            this.dgv_LogDetail.Name = "dgv_LogDetail";
            this.dgv_LogDetail.RowHeadersVisible = false;
            this.dgv_LogDetail.RowTemplate.Height = 23;
            this.dgv_LogDetail.Size = new System.Drawing.Size(198, 394);
            this.dgv_LogDetail.TabIndex = 4;
            this.dgv_LogDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LogDetail_CellEndEdit);
            // 
            // btn_AddLogField
            // 
            this.btn_AddLogField.BackColor = System.Drawing.Color.White;
            this.btn_AddLogField.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AddLogField.Location = new System.Drawing.Point(958, 16);
            this.btn_AddLogField.Name = "btn_AddLogField";
            this.btn_AddLogField.Size = new System.Drawing.Size(75, 23);
            this.btn_AddLogField.TabIndex = 5;
            this.btn_AddLogField.Text = "필드 추가";
            this.btn_AddLogField.UseVisualStyleBackColor = false;
            this.btn_AddLogField.Click += new System.EventHandler(this.btn_AddLogField_Click);
            // 
            // dgv_LogCommon
            // 
            this.dgv_LogCommon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LogCommon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogCommon.Location = new System.Drawing.Point(812, 45);
            this.dgv_LogCommon.Name = "dgv_LogCommon";
            this.dgv_LogCommon.RowHeadersVisible = false;
            this.dgv_LogCommon.RowTemplate.Height = 23;
            this.dgv_LogCommon.Size = new System.Drawing.Size(140, 394);
            this.dgv_LogCommon.TabIndex = 6;
            // 
            // cb_LogCommonList
            // 
            this.cb_LogCommonList.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_LogCommonList.FormattingEnabled = true;
            this.cb_LogCommonList.Location = new System.Drawing.Point(1035, 17);
            this.cb_LogCommonList.Name = "cb_LogCommonList";
            this.cb_LogCommonList.Size = new System.Drawing.Size(121, 23);
            this.cb_LogCommonList.TabIndex = 7;
            this.cb_LogCommonList.SelectedIndexChanged += new System.EventHandler(this.cb_LogCommonList_SelectedIndexChanged);
            this.cb_LogCommonList.Click += new System.EventHandler(this.cb_LogCommonList_Click);
            // 
            // btn_SaveLogType
            // 
            this.btn_SaveLogType.BackColor = System.Drawing.Color.White;
            this.btn_SaveLogType.Font = new System.Drawing.Font("Infinity Sans WM Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SaveLogType.Location = new System.Drawing.Point(697, 17);
            this.btn_SaveLogType.Name = "btn_SaveLogType";
            this.btn_SaveLogType.Size = new System.Drawing.Size(109, 23);
            this.btn_SaveLogType.TabIndex = 8;
            this.btn_SaveLogType.Text = "로그 타입 저장하기";
            this.btn_SaveLogType.UseVisualStyleBackColor = false;
            this.btn_SaveLogType.Click += new System.EventHandler(this.btn_SaveLogType_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.Controls.Add(this.btn_SaveLogType);
            this.Controls.Add(this.cb_LogCommonList);
            this.Controls.Add(this.dgv_LogCommon);
            this.Controls.Add(this.btn_AddLogField);
            this.Controls.Add(this.dgv_LogDetail);
            this.Controls.Add(this.dgv_TypeList);
            this.Controls.Add(this.rtxt_LogText);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_LoadLogSchema);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogCommon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadLogSchema;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.RichTextBox rtxt_LogText;
        public System.Windows.Forms.DataGridView dgv_TypeList;
        public System.Windows.Forms.DataGridView dgv_LogDetail;
        private System.Windows.Forms.Button btn_AddLogField;
        public System.Windows.Forms.DataGridView dgv_LogCommon;
        private System.Windows.Forms.ComboBox cb_LogCommonList;
        private System.Windows.Forms.Button btn_SaveLogType;
    }
}

