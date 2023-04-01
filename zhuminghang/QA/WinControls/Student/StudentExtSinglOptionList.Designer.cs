
namespace Kuade.WinControls.Student
{
    partial class StudentExtSinglOptionList
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
            this.panelText = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.flowOption = new System.Windows.Forms.FlowLayoutPanel();
            this.flowText = new System.Windows.Forms.FlowLayoutPanel();
            this.panelText.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.lblText);
            this.panelText.Location = new System.Drawing.Point(0, 3);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(59, 264);
            this.panelText.TabIndex = 16;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(47, 12);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "(第1题)";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.panel.Controls.Add(this.flowOption);
            this.panel.Controls.Add(this.flowText);
            this.panel.Location = new System.Drawing.Point(65, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1086, 264);
            this.panel.TabIndex = 15;
            // 
            // flowOption
            // 
            this.flowOption.AutoScroll = true;
            this.flowOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowOption.Location = new System.Drawing.Point(0, 0);
            this.flowOption.Name = "flowOption";
            this.flowOption.Size = new System.Drawing.Size(88, 264);
            this.flowOption.TabIndex = 4;
            // 
            // flowText
            // 
            this.flowText.AutoScroll = true;
            this.flowText.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowText.Location = new System.Drawing.Point(94, 0);
            this.flowText.Name = "flowText";
            this.flowText.Size = new System.Drawing.Size(992, 264);
            this.flowText.TabIndex = 3;
            // 
            // StudentExtSinglOptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panel);
            this.Name = "StudentExtSinglOptionList";
            this.Size = new System.Drawing.Size(1151, 270);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelText;
        public System.Windows.Forms.Label lblText;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.FlowLayoutPanel flowOption;
        public System.Windows.Forms.FlowLayoutPanel flowText;
    }
}
