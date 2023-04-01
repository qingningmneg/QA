
namespace QA.winfrom
{
    partial class FrmUserEditPwd
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
            this.lblRePwd = new System.Windows.Forms.LinkLabel();
            this.btnCenCel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreservation = new DevExpress.XtraEditors.SimpleButton();
            this.txtReUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.lblReUserPwd = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.lblUserPwd = new DevExpress.XtraEditors.LabelControl();
            this.txtPwd = new DevExpress.XtraEditors.TextEdit();
            this.lblPwd = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtReUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRePwd
            // 
            this.lblRePwd.AutoSize = true;
            this.lblRePwd.Location = new System.Drawing.Point(334, 230);
            this.lblRePwd.Name = "lblRePwd";
            this.lblRePwd.Size = new System.Drawing.Size(55, 14);
            this.lblRePwd.TabIndex = 17;
            this.lblRePwd.TabStop = true;
            this.lblRePwd.Text = "忘记密码";
            this.lblRePwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRePwd_LinkClicked);
            // 
            // btnCenCel
            // 
            this.btnCenCel.Location = new System.Drawing.Point(229, 221);
            this.btnCenCel.Name = "btnCenCel";
            this.btnCenCel.Size = new System.Drawing.Size(75, 23);
            this.btnCenCel.TabIndex = 16;
            this.btnCenCel.Text = "取消";
            this.btnCenCel.Click += new System.EventHandler(this.btnCenCel_Click);
            // 
            // btnPreservation
            // 
            this.btnPreservation.Location = new System.Drawing.Point(137, 221);
            this.btnPreservation.Name = "btnPreservation";
            this.btnPreservation.Size = new System.Drawing.Size(75, 23);
            this.btnPreservation.TabIndex = 15;
            this.btnPreservation.Text = "保存";
            this.btnPreservation.Click += new System.EventHandler(this.btnPreservation_Click);
            // 
            // txtReUserPwd
            // 
            this.txtReUserPwd.Location = new System.Drawing.Point(171, 160);
            this.txtReUserPwd.Name = "txtReUserPwd";
            this.txtReUserPwd.Size = new System.Drawing.Size(150, 20);
            this.txtReUserPwd.TabIndex = 14;
            // 
            // lblReUserPwd
            // 
            this.lblReUserPwd.Location = new System.Drawing.Point(113, 163);
            this.lblReUserPwd.Name = "lblReUserPwd";
            this.lblReUserPwd.Size = new System.Drawing.Size(52, 14);
            this.lblReUserPwd.TabIndex = 13;
            this.lblReUserPwd.Text = "确认密码:";
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(171, 115);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Size = new System.Drawing.Size(150, 20);
            this.txtUserPwd.TabIndex = 12;
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.Location = new System.Drawing.Point(125, 118);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(40, 14);
            this.lblUserPwd.TabIndex = 11;
            this.lblUserPwd.Text = "新密码:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(171, 70);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(150, 20);
            this.txtPwd.TabIndex = 10;
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(125, 73);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(40, 14);
            this.lblPwd.TabIndex = 9;
            this.lblPwd.Text = "旧密码:";
            // 
            // FrmUserEditPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 315);
            this.Controls.Add(this.lblRePwd);
            this.Controls.Add(this.btnCenCel);
            this.Controls.Add(this.btnPreservation);
            this.Controls.Add(this.txtReUserPwd);
            this.Controls.Add(this.lblReUserPwd);
            this.Controls.Add(this.txtUserPwd);
            this.Controls.Add(this.lblUserPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Name = "FrmUserEditPwd";
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.txtReUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblRePwd;
        private DevExpress.XtraEditors.SimpleButton btnCenCel;
        private DevExpress.XtraEditors.SimpleButton btnPreservation;
        private DevExpress.XtraEditors.TextEdit txtReUserPwd;
        private DevExpress.XtraEditors.LabelControl lblReUserPwd;
        private DevExpress.XtraEditors.TextEdit txtUserPwd;
        private DevExpress.XtraEditors.LabelControl lblUserPwd;
        private DevExpress.XtraEditors.TextEdit txtPwd;
        private DevExpress.XtraEditors.LabelControl lblPwd;
    }
}