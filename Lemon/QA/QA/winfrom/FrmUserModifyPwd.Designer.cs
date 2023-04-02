
namespace QA.winfrom
{
    partial class FrmUserModifyPwd
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
            this.txtUserNo = new DevExpress.XtraEditors.TextEdit();
            this.lblUserNo = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserPwd = new DevExpress.XtraEditors.SimpleButton();
            this.lblContent = new DevExpress.XtraEditors.LabelControl();
            this.lblAttnNum = new DevExpress.XtraEditors.LabelControl();
            this.txtContent = new DevExpress.XtraEditors.TextEdit();
            this.txtAttnNum = new DevExpress.XtraEditors.TextEdit();
            this.btnContent = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttnNum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(167, 61);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(198, 20);
            this.txtUserNo.TabIndex = 18;
            // 
            // lblUserNo
            // 
            this.lblUserNo.Location = new System.Drawing.Point(86, 64);
            this.lblUserNo.Name = "lblUserNo";
            this.lblUserNo.Size = new System.Drawing.Size(48, 14);
            this.lblUserNo.TabIndex = 17;
            this.lblUserNo.Text = "用户名：";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(260, 209);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(87, 23);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "取消";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnUserPwd
            // 
            this.btnUserPwd.Location = new System.Drawing.Point(142, 209);
            this.btnUserPwd.Name = "btnUserPwd";
            this.btnUserPwd.Size = new System.Drawing.Size(77, 23);
            this.btnUserPwd.TabIndex = 15;
            this.btnUserPwd.Text = "修改密码";
            this.btnUserPwd.Click += new System.EventHandler(this.btnUserPwd_Click);
            // 
            // lblContent
            // 
            this.lblContent.Location = new System.Drawing.Point(113, 150);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(48, 14);
            this.lblContent.TabIndex = 14;
            this.lblContent.Text = "验证码：";
            // 
            // lblAttnNum
            // 
            this.lblAttnNum.Location = new System.Drawing.Point(41, 104);
            this.lblAttnNum.Name = "lblAttnNum";
            this.lblAttnNum.Size = new System.Drawing.Size(120, 14);
            this.lblAttnNum.TabIndex = 13;
            this.lblAttnNum.Text = "输入您的绑定手机号：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(167, 147);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(198, 20);
            this.txtContent.TabIndex = 12;
            // 
            // txtAttnNum
            // 
            this.txtAttnNum.Location = new System.Drawing.Point(167, 101);
            this.txtAttnNum.Name = "txtAttnNum";
            this.txtAttnNum.Size = new System.Drawing.Size(198, 20);
            this.txtAttnNum.TabIndex = 11;
            // 
            // btnContent
            // 
            this.btnContent.Location = new System.Drawing.Point(371, 146);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(81, 23);
            this.btnContent.TabIndex = 10;
            this.btnContent.Text = "发送验证码";
            this.btnContent.Click += new System.EventHandler(this.btnContent_Click);
            // 
            // FrmUserModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 278);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.lblUserNo);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnUserPwd);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblAttnNum);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtAttnNum);
            this.Controls.Add(this.btnContent);
            this.Name = "FrmUserModifyPwd";
            this.Text = "忘记密码";
            this.Load += new System.EventHandler(this.FrmUserModifyPwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttnNum.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserNo;
        private DevExpress.XtraEditors.LabelControl lblUserNo;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnUserPwd;
        private DevExpress.XtraEditors.LabelControl lblContent;
        private DevExpress.XtraEditors.LabelControl lblAttnNum;
        private DevExpress.XtraEditors.TextEdit txtContent;
        private DevExpress.XtraEditors.TextEdit txtAttnNum;
        private DevExpress.XtraEditors.SimpleButton btnContent;
    }
}