
namespace Kuade.WinControls.ExtOption
{
    partial class ExtSinglOptionList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtSinglOptionList));
            this.flowText = new System.Windows.Forms.FlowLayoutPanel();
            this.flowOption = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this.extAnalysis1 = new Kuade.WinControls.ExtAnalysis();
            this.panelText = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCencel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnObtain = new DevExpress.XtraBars.BarButtonItem();
            this.btnObtains = new DevExpress.XtraBars.BarButtonItem();
            this.panel.SuspendLayout();
            this.panelText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // flowText
            // 
            this.flowText.AutoScroll = true;
            this.flowText.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowText.Location = new System.Drawing.Point(95, 0);
            this.flowText.Name = "flowText";
            this.flowText.Size = new System.Drawing.Size(980, 264);
            this.flowText.TabIndex = 3;
            this.flowText.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            // 
            // flowOption
            // 
            this.flowOption.AutoScroll = true;
            this.flowOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowOption.Location = new System.Drawing.Point(0, 0);
            this.flowOption.Name = "flowOption";
            this.flowOption.Size = new System.Drawing.Size(88, 264);
            this.flowOption.TabIndex = 4;
            this.flowOption.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel2_Scroll);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.panel.Controls.Add(this.flowOption);
            this.panel.Controls.Add(this.flowText);
            this.panel.Location = new System.Drawing.Point(65, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1075, 264);
            this.panel.TabIndex = 13;
            // 
            // extAnalysis1
            // 
            this.extAnalysis1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.extAnalysis1.Location = new System.Drawing.Point(0, 294);
            this.extAnalysis1.Name = "extAnalysis1";
            this.extAnalysis1.Size = new System.Drawing.Size(1144, 173);
            this.extAnalysis1.TabIndex = 5;
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.lblText);
            this.panelText.Location = new System.Drawing.Point(0, 24);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(59, 264);
            this.panelText.TabIndex = 14;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(53, 12);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "(第一题)";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btndelete,
            this.btnCencel,
            this.btnObtain,
            this.btnObtains});
            this.barManager.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btndelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCencel)});
            this.bar1.Offset = 108;
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "添加选项";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "删除选线";
            this.btndelete.Id = 1;
            this.btndelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btndelete.ImageOptions.SvgImage")));
            this.btndelete.Name = "btndelete";
            this.btndelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btndelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndelete_ItemClick);
            // 
            // btnCencel
            // 
            this.btnCencel.Caption = "清空选项";
            this.btnCencel.Id = 2;
            this.btnCencel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCencel.ImageOptions.SvgImage")));
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCencel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCencel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1144, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1144, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 443);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1144, 24);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 443);
            // 
            // btnObtain
            // 
            this.btnObtain.Caption = "获取答案";
            this.btnObtain.Id = 3;
            this.btnObtain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnObtain.ImageOptions.Image")));
            this.btnObtain.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnObtain.ImageOptions.LargeImage")));
            this.btnObtain.Name = "btnObtain";
            this.btnObtain.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnObtains
            // 
            this.btnObtains.Caption = "获取解析";
            this.btnObtains.Id = 4;
            this.btnObtains.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnObtains.ImageOptions.SvgImage")));
            this.btnObtains.Name = "btnObtains";
            this.btnObtains.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnObtains.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObtains_ItemClick);
            // 
            // ExtSinglOptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.extAnalysis1);
            this.Controls.Add(this.panelText);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ExtSinglOptionList";
            this.Size = new System.Drawing.Size(1144, 467);
            this.Load += new System.EventHandler(this.ExtMulitOptionListSingle_Load);
            this.panel.ResumeLayout(false);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flowOption;
        public System.Windows.Forms.FlowLayoutPanel flowText;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Panel panelText;
        public DevExpress.XtraBars.BarManager barManager;
        public DevExpress.XtraBars.Bar bar1;
        public DevExpress.XtraBars.BarButtonItem btnAdd;
        public DevExpress.XtraBars.BarButtonItem btndelete;
        public DevExpress.XtraBars.BarButtonItem btnCencel;
        public DevExpress.XtraBars.BarDockControl barDockControlTop;
        public DevExpress.XtraBars.BarDockControl barDockControlBottom;
        public DevExpress.XtraBars.BarDockControl barDockControlLeft;
        public DevExpress.XtraBars.BarDockControl barDockControlRight;
        public System.Windows.Forms.Label lblText;
        public ExtAnalysis extAnalysis1;
        public DevExpress.XtraBars.BarButtonItem btnObtain;
        private DevExpress.XtraBars.BarButtonItem btnObtains;
    }
}
