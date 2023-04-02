
namespace Kuade.WinControls.Student
{
    partial class StudentExtAnswer
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
            this.ExtOptions1 = new Kuade.WinControls.ExtRichEdit();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExtOptions1
            // 
            this.ExtOptions1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.ExtOptions1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExtOptions1.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.ExtOptions1.Location = new System.Drawing.Point(62, 0);
            this.ExtOptions1.Name = "ExtOptions1";
            this.ExtOptions1.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.ExtOptions1.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.ExtOptions1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.ExtOptions1.Size = new System.Drawing.Size(1049, 464);
            this.ExtOptions1.TabIndex = 5;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 25);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(53, 12);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "第一题：";
            // 
            // StudentExtAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.ExtOptions1);
            this.Name = "StudentExtAnswer";
            this.Size = new System.Drawing.Size(1111, 464);
            this.Load += new System.EventHandler(this.StudentExtAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ExtRichEdit ExtOptions1;
        private System.Windows.Forms.Label lblText;
    }
}
