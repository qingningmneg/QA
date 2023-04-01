
namespace Kuade.WinControls
{
    partial class ExtAnswer
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.extAnalysis1 = new Kuade.WinControls.ExtAnalysis();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "答题框1：";
            // 
            // extAnalysis1
            // 
            this.extAnalysis1.Dock = System.Windows.Forms.DockStyle.Right;
            this.extAnalysis1.Location = new System.Drawing.Point(68, 0);
            this.extAnalysis1.Name = "extAnalysis1";
            this.extAnalysis1.Size = new System.Drawing.Size(1098, 183);
            this.extAnalysis1.TabIndex = 1;
            // 
            // ExtAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.extAnalysis1);
            this.Controls.Add(this.labelControl1);
            this.Name = "ExtAnswer";
            this.Size = new System.Drawing.Size(1166, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl labelControl1;
        public ExtAnalysis extAnalysis1;
    }
}
