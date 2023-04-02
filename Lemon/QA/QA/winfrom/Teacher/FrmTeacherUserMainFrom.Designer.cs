
namespace QA.winfrom
{
    partial class FrmTeacherUserMainFrom
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
            this.components = new System.ComponentModel.Container();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnUserModify = new DevExpress.XtraBars.BarButtonItem();
            this.btnCencel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.btnyear = new DevExpress.XtraNavBar.NavBarGroup();
            this.btntypes = new DevExpress.XtraNavBar.NavBarItem();
            this.btnyears = new DevExpress.XtraNavBar.NavBarItem();
            this.barInformation = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnInsert = new DevExpress.XtraNavBar.NavBarItem();
            this.barQuestionsEdit = new DevExpress.XtraNavBar.NavBarItem();
            this.btnInserts = new DevExpress.XtraNavBar.NavBarItem();
            this.barQuestionsEdits = new DevExpress.XtraNavBar.NavBarItem();
            this.btnImport = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.MenuManager = this.barManager;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
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
            this.btnUserModify,
            this.btnCencel});
            this.barManager.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(1124, 135);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUserModify),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCencel)});
            this.bar1.Text = "Tools";
            // 
            // btnUserModify
            // 
            this.btnUserModify.Caption = "用户信息管理";
            this.btnUserModify.Id = 0;
            this.btnUserModify.ImageOptions.Image = global::QA.Properties.Resources.btnUserModify_ImageOptions_Image;
            this.btnUserModify.Name = "btnUserModify";
            this.btnUserModify.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUserModify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUserModify_ItemClick);
            // 
            // btnCencel
            // 
            this.btnCencel.Caption = "退出登录";
            this.btnCencel.Id = 2;
            this.btnCencel.ImageOptions.Image = global::QA.Properties.Resources.btnCencel_ImageOptions_Image;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1597, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 752);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1597, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 711);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1597, 41);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 711);
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.dockPanel1_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel.ID = new System.Guid("67e9c156-4056-47b1-ae35-1606bb9bd616");
            this.dockPanel.Location = new System.Drawing.Point(0, 41);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel.Size = new System.Drawing.Size(200, 711);
            this.dockPanel.Text = "考试信息管理";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 682);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.btnyear;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.btnyear,
            this.barInformation});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnInserts,
            this.barQuestionsEdits,
            this.btntypes,
            this.btnyears,
            this.btnInsert,
            this.barQuestionsEdit,
            this.btnImport});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl.Size = new System.Drawing.Size(193, 682);
            this.navBarControl.TabIndex = 10;
            this.navBarControl.Text = "navBarControl1";
            // 
            // btnyear
            // 
            this.btnyear.Caption = "考题分类管理";
            this.btnyear.Expanded = true;
            this.btnyear.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btntypes),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnyears)});
            this.btnyear.Name = "btnyear";
            // 
            // btntypes
            // 
            this.btntypes.Caption = "类型编辑";
            this.btntypes.Name = "btntypes";
            this.btntypes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btntypes_LinkClicked);
            // 
            // btnyears
            // 
            this.btnyears.Caption = "年份编辑";
            this.btnyears.Name = "btnyears";
            this.btnyears.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnyears_LinkClicked);
            // 
            // barInformation
            // 
            this.barInformation.Caption = "考试信息维护";
            this.barInformation.Expanded = true;
            this.barInformation.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnInsert),
            new DevExpress.XtraNavBar.NavBarItemLink(this.barQuestionsEdit),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnImport)});
            this.barInformation.Name = "barInformation";
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "添加考题";
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnInsert_LinkClicked);
            // 
            // barQuestionsEdit
            // 
            this.barQuestionsEdit.Caption = "编辑考题";
            this.barQuestionsEdit.Name = "barQuestionsEdit";
            this.barQuestionsEdit.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.barQuestionsEdit_LinkClicked);
            // 
            // btnInserts
            // 
            this.btnInserts.Caption = "添加考题";
            this.btnInserts.Name = "btnInserts";
            // 
            // barQuestionsEdits
            // 
            this.barQuestionsEdits.Caption = "编辑考题";
            this.barQuestionsEdits.Name = "barQuestionsEdits";
            // 
            // btnImport
            // 
            this.btnImport.Caption = "导入考题";
            this.btnImport.Name = "btnImport";
            this.btnImport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnImport_LinkClicked);
            // 
            // FrmTeacherUserMainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 752);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "FrmTeacherUserMainFrom";
            this.Text = "老师考试窗体";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnUserModify;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup btnyear;
        private DevExpress.XtraNavBar.NavBarItem btntypes;
        private DevExpress.XtraNavBar.NavBarItem btnyears;
        private DevExpress.XtraNavBar.NavBarGroup barInformation;
        private DevExpress.XtraNavBar.NavBarItem btnInsert;
        private DevExpress.XtraNavBar.NavBarItem barQuestionsEdit;
        private DevExpress.XtraNavBar.NavBarItem btnInserts;
        private DevExpress.XtraNavBar.NavBarItem barQuestionsEdits;
        private DevExpress.XtraBars.BarButtonItem btnCencel;
        private DevExpress.XtraNavBar.NavBarItem btnImport;
    }
}