
namespace QA.winfrom
{
    partial class FrmUserRegister
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
            this.components = new System.ComponentModel.Container();
            this.lblUserNames = new DevExpress.XtraEditors.LabelControl();
            this.lblReUserPwds = new DevExpress.XtraEditors.LabelControl();
            this.lblUserPwds = new DevExpress.XtraEditors.LabelControl();
            this.lblUserNos = new DevExpress.XtraEditors.LabelControl();
            this.txtCardNo = new DevExpress.XtraEditors.TextEdit();
            this.lblCardNo = new DevExpress.XtraEditors.LabelControl();
            this.btnimage = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtReUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblReUserPwd = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnCencel = new DevExpress.XtraEditors.SimpleButton();
            this.txtUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtUserNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblUserPwd = new DevExpress.XtraEditors.LabelControl();
            this.lblUserNo = new DevExpress.XtraEditors.LabelControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserNames
            // 
            this.lblUserNames.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblUserNames.Appearance.Options.UseForeColor = true;
            this.lblUserNames.Location = new System.Drawing.Point(310, 257);
            this.lblUserNames.Name = "lblUserNames";
            this.lblUserNames.Size = new System.Drawing.Size(96, 14);
            this.lblUserNames.TabIndex = 43;
            this.lblUserNames.Text = "用户姓名不能为空";
            // 
            // lblReUserPwds
            // 
            this.lblReUserPwds.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblReUserPwds.Appearance.Options.UseForeColor = true;
            this.lblReUserPwds.Location = new System.Drawing.Point(310, 216);
            this.lblReUserPwds.Name = "lblReUserPwds";
            this.lblReUserPwds.Size = new System.Drawing.Size(84, 14);
            this.lblReUserPwds.TabIndex = 42;
            this.lblReUserPwds.Text = "两次密码不一致";
            // 
            // lblUserPwds
            // 
            this.lblUserPwds.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblUserPwds.Appearance.Options.UseForeColor = true;
            this.lblUserPwds.Location = new System.Drawing.Point(310, 174);
            this.lblUserPwds.Name = "lblUserPwds";
            this.lblUserPwds.Size = new System.Drawing.Size(72, 14);
            this.lblUserPwds.TabIndex = 41;
            this.lblUserPwds.Text = "密码不能为空";
            // 
            // lblUserNos
            // 
            this.lblUserNos.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblUserNos.Appearance.Options.UseForeColor = true;
            this.lblUserNos.Location = new System.Drawing.Point(310, 130);
            this.lblUserNos.Name = "lblUserNos";
            this.lblUserNos.Size = new System.Drawing.Size(84, 14);
            this.lblUserNos.TabIndex = 40;
            this.lblUserNos.Text = "用户名不能为空";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(307, 64);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(180, 20);
            this.txtCardNo.TabIndex = 39;
            // 
            // lblCardNo
            // 
            this.lblCardNo.Location = new System.Drawing.Point(250, 67);
            this.lblCardNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(40, 14);
            this.lblCardNo.TabIndex = 38;
            this.lblCardNo.Text = "卡   号:";
            // 
            // btnimage
            // 
            this.btnimage.Location = new System.Drawing.Point(121, 219);
            this.btnimage.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(82, 27);
            this.btnimage.TabIndex = 37;
            this.btnimage.Text = "图片";
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(307, 235);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(180, 20);
            this.txtUserName.TabIndex = 36;
            this.txtUserName.EditValueChanged += new System.EventHandler(this.txtUserName_EditValueChanged);
            // 
            // txtReUserPwd
            // 
            this.txtReUserPwd.Location = new System.Drawing.Point(307, 193);
            this.txtReUserPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtReUserPwd.Name = "txtReUserPwd";
            this.txtReUserPwd.Size = new System.Drawing.Size(180, 20);
            this.txtReUserPwd.TabIndex = 35;
            this.txtReUserPwd.EditValueChanged += new System.EventHandler(this.txtReUserPwd_EditValueChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(250, 238);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(52, 14);
            this.lblUserName.TabIndex = 34;
            this.lblUserName.Text = "用户姓名:";
            // 
            // lblReUserPwd
            // 
            this.lblReUserPwd.Location = new System.Drawing.Point(250, 196);
            this.lblReUserPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblReUserPwd.Name = "lblReUserPwd";
            this.lblReUserPwd.Size = new System.Drawing.Size(52, 14);
            this.lblReUserPwd.TabIndex = 33;
            this.lblReUserPwd.Text = "确认密码:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(178, 292);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 26);
            this.btnRegister.TabIndex = 31;
            this.btnRegister.Text = "注册";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(295, 292);
            this.btnCencel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(87, 26);
            this.btnCencel.TabIndex = 32;
            this.btnCencel.Text = "取消";
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(307, 149);
            this.txtUserPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(180, 20);
            this.txtUserPwd.TabIndex = 30;
            this.txtUserPwd.EditValueChanged += new System.EventHandler(this.txtUserPwd_EditValueChanged);
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(307, 104);
            this.txtUserNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(180, 20);
            this.txtUserNo.TabIndex = 29;
            this.txtUserNo.EditValueChanged += new System.EventHandler(this.txtUserNo_EditValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::QA.Properties.Resources._default;
            this.pictureBox.Location = new System.Drawing.Point(96, 86);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 117);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.Location = new System.Drawing.Point(250, 152);
            this.lblUserPwd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(40, 14);
            this.lblUserPwd.TabIndex = 27;
            this.lblUserPwd.Text = "密   码:";
            // 
            // lblUserNo
            // 
            this.lblUserNo.Location = new System.Drawing.Point(250, 107);
            this.lblUserNo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(40, 14);
            this.lblUserNo.TabIndex = 26;
            this.lblUserNo.Text = "用户名:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 379);
            this.Controls.Add(this.lblUserNames);
            this.Controls.Add(this.lblReUserPwds);
            this.Controls.Add(this.lblUserPwds);
            this.Controls.Add(this.lblUserNos);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtReUserPwd);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblReUserPwd);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblUserPwd);
            this.Controls.Add(this.lblUserNo);
            this.Name = "FrmUserRegister";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.FrmUserRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCardNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUserNames;
        private DevExpress.XtraEditors.LabelControl lblReUserPwds;
        private DevExpress.XtraEditors.LabelControl lblUserPwds;
        private DevExpress.XtraEditors.LabelControl lblUserNos;
        private DevExpress.XtraEditors.TextEdit txtCardNo;
        private DevExpress.XtraEditors.LabelControl lblCardNo;
        private DevExpress.XtraEditors.SimpleButton btnimage;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtReUserPwd;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblReUserPwd;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnCencel;
        private DevExpress.XtraEditors.TextEdit txtUserPwd;
        private DevExpress.XtraEditors.TextEdit txtUserNo;
        private System.Windows.Forms.PictureBox pictureBox;
        private DevExpress.XtraEditors.LabelControl lblUserPwd;
        private DevExpress.XtraEditors.LabelControl lblUserNo;
        private System.Windows.Forms.Timer timer;
    }
}