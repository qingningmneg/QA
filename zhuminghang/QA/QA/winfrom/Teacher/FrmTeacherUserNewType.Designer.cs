
namespace QA.winfrom
{
    partial class FrmTeacherUserNewType
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
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtusertype = new DevExpress.XtraEditors.TextEdit();
            this.lblusertype = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtusertype.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(154, 204);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 27);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "保存";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtusertype
            // 
            this.txtusertype.Location = new System.Drawing.Point(193, 109);
            this.txtusertype.Name = "txtusertype";
            this.txtusertype.Size = new System.Drawing.Size(158, 20);
            this.txtusertype.TabIndex = 4;
            // 
            // lblusertype
            // 
            this.lblusertype.Location = new System.Drawing.Point(136, 113);
            this.lblusertype.Name = "lblusertype";
            this.lblusertype.Size = new System.Drawing.Size(40, 14);
            this.lblusertype.TabIndex = 3;
            this.lblusertype.Text = "新科目:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(247, 204);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 27);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "取消";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmTeacherUserNewType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 348);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtusertype);
            this.Controls.Add(this.lblusertype);
            this.Name = "FrmTeacherUserNewType";
            this.Text = "科目";
            ((System.ComponentModel.ISupportInitialize)(this.txtusertype.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtusertype;
        private DevExpress.XtraEditors.LabelControl lblusertype;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}