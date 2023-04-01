
namespace QA.winfrom
{
    partial class FrmUserPwd
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
            this.btnCenCel = new DevExpress.XtraEditors.SimpleButton();
            this.btnlogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtReUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.lblReUserPwd = new DevExpress.XtraEditors.LabelControl();
            this.lblUserPwd = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtReUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCenCel
            // 
            this.btnCenCel.Location = new System.Drawing.Point(260, 228);
            this.btnCenCel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCenCel.Name = "btnCenCel";
            this.btnCenCel.Size = new System.Drawing.Size(88, 27);
            this.btnCenCel.TabIndex = 11;
            this.btnCenCel.Text = "取消";
            this.btnCenCel.Click += new System.EventHandler(this.btnCenCel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(148, 228);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(88, 27);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.Text = "确认";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtReUserPwd
            // 
            this.txtReUserPwd.Location = new System.Drawing.Point(197, 147);
            this.txtReUserPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtReUserPwd.Name = "txtReUserPwd";
            this.txtReUserPwd.Size = new System.Drawing.Size(176, 20);
            this.txtReUserPwd.TabIndex = 9;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(197, 84);
            this.txtUserPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(176, 20);
            this.txtUserPwd.TabIndex = 8;
            // 
            // lblReUserPwd
            // 
            this.lblReUserPwd.Location = new System.Drawing.Point(115, 151);
            this.lblReUserPwd.Margin = new System.Windows.Forms.Padding(4);
            this.lblReUserPwd.Name = "lblReUserPwd";
            this.lblReUserPwd.Size = new System.Drawing.Size(52, 14);
            this.lblReUserPwd.TabIndex = 7;
            this.lblReUserPwd.Text = "确认密码:";
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.Location = new System.Drawing.Point(115, 84);
            this.lblUserPwd.Margin = new System.Windows.Forms.Padding(4);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(40, 14);
            this.lblUserPwd.TabIndex = 6;
            this.lblUserPwd.Text = "密   码:";
            // 
            // FrmUserPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 331);
            this.Controls.Add(this.btnCenCel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtReUserPwd);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.lblReUserPwd);
            this.Controls.Add(this.lblUserPwd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUserPwd";
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.txtReUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCenCel;
        private DevExpress.XtraEditors.SimpleButton btnlogin;
        private DevExpress.XtraEditors.TextEdit txtReUserPwd;
        private DevExpress.XtraEditors.TextEdit txtUserPwd;
        private DevExpress.XtraEditors.LabelControl lblReUserPwd;
        private DevExpress.XtraEditors.LabelControl lblUserPwd;
    }
}