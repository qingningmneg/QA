
namespace Kuade.WinControls
{
    partial class StudentButt
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandom.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRandom.Location = new System.Drawing.Point(0, 0);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(253, 558);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "随机考题";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.MouseLeave += new System.EventHandler(this.btnRandom_MouseLeave);
            this.btnRandom.MouseHover += new System.EventHandler(this.btnRandom_MouseHover);
            // 
            // StudentButt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRandom);
            this.Name = "StudentButt";
            this.Size = new System.Drawing.Size(253, 558);
            this.Load += new System.EventHandler(this.StudentButt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnRandom;
    }
}
