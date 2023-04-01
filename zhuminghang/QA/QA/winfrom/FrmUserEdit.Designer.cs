
namespace QA
{
    partial class FrmUserEdit
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
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.txtUserYear = new DevExpress.XtraEditors.DateEdit();
            this.lblUserNo = new DevExpress.XtraEditors.LabelControl();
            this.lblUserPwd = new System.Windows.Forms.LinkLabel();
            this.btnCenCel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreservation = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelephone = new DevExpress.XtraEditors.TextEdit();
            this.txtUserAge = new DevExpress.XtraEditors.TextEdit();
            this.txtUserSex = new System.Windows.Forms.ComboBox();
            this.lblTelephone = new DevExpress.XtraEditors.LabelControl();
            this.lblReUserNo = new DevExpress.XtraEditors.LabelControl();
            this.lblUserYear = new DevExpress.XtraEditors.LabelControl();
            this.lblUserSex = new DevExpress.XtraEditors.LabelControl();
            this.lblUserAge = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserAge.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(149, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(146, 20);
            this.txtUserName.TabIndex = 47;
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(76, 84);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(52, 14);
            this.lblUserName.TabIndex = 46;
            this.lblUserName.Text = "用户姓名:";
            // 
            // txtUserYear
            // 
            this.txtUserYear.EditValue = null;
            this.txtUserYear.Location = new System.Drawing.Point(149, 195);
            this.txtUserYear.Name = "txtUserYear";
            this.txtUserYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUserYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUserYear.Size = new System.Drawing.Size(146, 20);
            this.txtUserYear.TabIndex = 45;
            // 
            // lblUserNo
            // 
            this.lblUserNo.Location = new System.Drawing.Point(149, 54);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(36, 14);
            this.lblUserNo.TabIndex = 44;
            this.lblUserNo.Text = "用户名";
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.AutoSize = true;
            this.lblUserPwd.Location = new System.Drawing.Point(298, 269);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(55, 14);
            this.lblUserPwd.TabIndex = 43;
            this.lblUserPwd.TabStop = true;
            this.lblUserPwd.Text = "修改密码";
            this.lblUserPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUserPwd_LinkClicked);
            // 
            // btnCenCel
            // 
            this.btnCenCel.Location = new System.Drawing.Point(210, 286);
            this.btnCenCel.Name = "btnCenCel";
            this.btnCenCel.Size = new System.Drawing.Size(75, 23);
            this.btnCenCel.TabIndex = 42;
            this.btnCenCel.Text = "取消";
            this.btnCenCel.Click += new System.EventHandler(this.btnCenCel_Click);
            // 
            // btnPreservation
            // 
            this.btnPreservation.Location = new System.Drawing.Point(89, 286);
            this.btnPreservation.Name = "btnPreservation";
            this.btnPreservation.Size = new System.Drawing.Size(75, 23);
            this.btnPreservation.TabIndex = 41;
            this.btnPreservation.Text = "保存";
            this.btnPreservation.Click += new System.EventHandler(this.btnPreservation_Click);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(149, 236);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(146, 20);
            this.txtTelephone.TabIndex = 40;
            // 
            // txtUserAge
            // 
            this.txtUserAge.Location = new System.Drawing.Point(149, 117);
            this.txtUserAge.Name = "txtUserAge";
            this.txtUserAge.Size = new System.Drawing.Size(146, 20);
            this.txtUserAge.TabIndex = 39;
            // 
            // txtUserSex
            // 
            this.txtUserSex.FormattingEnabled = true;
            this.txtUserSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.txtUserSex.Location = new System.Drawing.Point(149, 153);
            this.txtUserSex.Name = "txtUserSex";
            this.txtUserSex.Size = new System.Drawing.Size(146, 22);
            this.txtUserSex.TabIndex = 38;
            // 
            // lblTelephone
            // 
            this.lblTelephone.Location = new System.Drawing.Point(68, 239);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(60, 14);
            this.lblTelephone.TabIndex = 37;
            this.lblTelephone.Text = "联系电话：";
            // 
            // lblReUserNo
            // 
            this.lblReUserNo.Location = new System.Drawing.Point(88, 54);
            this.lblReUserNo.Name = "lblReUserNo";
            this.lblReUserNo.Size = new System.Drawing.Size(40, 14);
            this.lblReUserNo.TabIndex = 33;
            this.lblReUserNo.Text = "用户名:";
            // 
            // lblUserYear
            // 
            this.lblUserYear.Location = new System.Drawing.Point(68, 198);
            this.lblUserYear.Name = "lblUserYear";
            this.lblUserYear.Size = new System.Drawing.Size(60, 14);
            this.lblUserYear.TabIndex = 36;
            this.lblUserYear.Text = "出生日期：";
            // 
            // lblUserSex
            // 
            this.lblUserSex.Location = new System.Drawing.Point(87, 156);
            this.lblUserSex.Name = "lblUserSex";
            this.lblUserSex.Size = new System.Drawing.Size(40, 14);
            this.lblUserSex.TabIndex = 34;
            this.lblUserSex.Text = "性   别:";
            // 
            // lblUserAge
            // 
            this.lblUserAge.Location = new System.Drawing.Point(88, 120);
            this.lblUserAge.Name = "lblUserAge";
            this.lblUserAge.Size = new System.Drawing.Size(48, 14);
            this.lblUserAge.TabIndex = 35;
            this.lblUserAge.Text = "年   龄：";
            // 
            // FrmUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 359);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserYear);
            this.Controls.Add(this.lblUserNo);
            this.Controls.Add(this.lblUserPwd);
            this.Controls.Add(this.btnCenCel);
            this.Controls.Add(this.btnPreservation);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtUserAge);
            this.Controls.Add(this.txtUserSex);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblReUserNo);
            this.Controls.Add(this.lblUserYear);
            this.Controls.Add(this.lblUserSex);
            this.Controls.Add(this.lblUserAge);
            this.Name = "FrmUserEdit";
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.FrmUserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserAge.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.DateEdit txtUserYear;
        private DevExpress.XtraEditors.LabelControl lblUserNo;
        private System.Windows.Forms.LinkLabel lblUserPwd;
        private DevExpress.XtraEditors.SimpleButton btnCenCel;
        private DevExpress.XtraEditors.SimpleButton btnPreservation;
        private DevExpress.XtraEditors.TextEdit txtTelephone;
        private DevExpress.XtraEditors.TextEdit txtUserAge;
        private System.Windows.Forms.ComboBox txtUserSex;
        private DevExpress.XtraEditors.LabelControl lblTelephone;
        private DevExpress.XtraEditors.LabelControl lblReUserNo;
        private DevExpress.XtraEditors.LabelControl lblUserYear;
        private DevExpress.XtraEditors.LabelControl lblUserSex;
        private DevExpress.XtraEditors.LabelControl lblUserAge;
    }
}