
namespace Kuade.WinControls.Student
{
    partial class StudentExtJudge
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new DevExpress.XtraEditors.LabelControl();
            this.CkNo = new DevExpress.XtraEditors.CheckEdit();
            this.CkYes = new DevExpress.XtraEditors.CheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkYes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.CkNo);
            this.panel1.Controls.Add(this.CkYes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 79);
            this.panel1.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Appearance.Options.UseFont = true;
            this.lblUser.Location = new System.Drawing.Point(29, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 39);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "第1题";
            // 
            // CkNo
            // 
            this.CkNo.Location = new System.Drawing.Point(897, 17);
            this.CkNo.Name = "CkNo";
            this.CkNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkNo.Properties.Appearance.Options.UseFont = true;
            this.CkNo.Properties.Caption = "错误";
            this.CkNo.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.CkNo.Properties.RadioGroupIndex = 1;
            this.CkNo.Size = new System.Drawing.Size(327, 46);
            this.CkNo.TabIndex = 1;
            this.CkNo.TabStop = false;
            // 
            // CkYes
            // 
            this.CkYes.Location = new System.Drawing.Point(325, 17);
            this.CkYes.Name = "CkYes";
            this.CkYes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkYes.Properties.Appearance.Options.UseFont = true;
            this.CkYes.Properties.Caption = "正确";
            this.CkYes.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.CkYes.Properties.RadioGroupIndex = 1;
            this.CkYes.Size = new System.Drawing.Size(327, 46);
            this.CkYes.TabIndex = 0;
            this.CkYes.TabStop = false;
            // 
            // StudentExtJudge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StudentExtJudge";
            this.Size = new System.Drawing.Size(1308, 81);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CkNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CkYes.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblUser;
        public DevExpress.XtraEditors.CheckEdit CkNo;
        public DevExpress.XtraEditors.CheckEdit CkYes;
    }
}
