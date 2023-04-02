
namespace Kuade.WinControls.Student
{
    partial class StudentExtOptions
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
            this.ExtOptions = new Kuade.WinControls.ExtRichEdit();
            this.SuspendLayout();
            // 
            // ExtOptions
            // 
            this.ExtOptions.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.ExtOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtOptions.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.ExtOptions.Location = new System.Drawing.Point(0, 0);
            this.ExtOptions.Name = "ExtOptions";
            this.ExtOptions.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.ExtOptions.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.ExtOptions.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.ExtOptions.Size = new System.Drawing.Size(966, 82);
            this.ExtOptions.TabIndex = 0;
            // 
            // StudentExtOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExtOptions);
            this.Name = "StudentExtOptions";
            this.Size = new System.Drawing.Size(966, 82);
            this.Load += new System.EventHandler(this.StudentExtOptions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public ExtRichEdit ExtOptions;
    }
}
