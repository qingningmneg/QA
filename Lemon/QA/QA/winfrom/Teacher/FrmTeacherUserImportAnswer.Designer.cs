
using System.Windows.Forms;

namespace QA.winfrom
{
    partial class FrmTeacherUserImportAnswer
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extOptions = new Kuade.WinControls.ExtOptions();
            this.lblsubject = new DevExpress.XtraEditors.LabelControl();
            this.txttopics = new DevExpress.XtraEditors.SpinEdit();
            this.lbltype = new DevExpress.XtraEditors.LabelControl();
            this.lbltopic = new DevExpress.XtraEditors.LabelControl();
            this.txttype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xialakuang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnPreservation = new DevExpress.XtraBars.BarButtonItem();
            this.btnaddto = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrest = new DevExpress.XtraBars.BarButtonItem();
            this.btnCencel = new DevExpress.XtraBars.BarButtonItem();
            this.btnall = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttopics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.splitContainerControl1.Panel1.Controls.Add(this.panel2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1715, 833);
            this.splitContainerControl1.SplitterPosition = 1369;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.FlowLayout);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 829);
            this.panel2.TabIndex = 1;
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayout.Location = new System.Drawing.Point(0, 163);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1365, 665);
            this.FlowLayout.TabIndex = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.extOptions);
            this.panel1.Controls.Add(this.lblsubject);
            this.panel1.Controls.Add(this.txttopics);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.lbltopic);
            this.panel1.Controls.Add(this.txttype);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 163);
            this.panel1.TabIndex = 156;
            // 
            // extOptions
            // 
            this.extOptions.Location = new System.Drawing.Point(76, 36);
            this.extOptions.Name = "extOptions";
            this.extOptions.Size = new System.Drawing.Size(1157, 121);
            this.extOptions.TabIndex = 155;
            // 
            // lblsubject
            // 
            this.lblsubject.Location = new System.Drawing.Point(10, 85);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(60, 14);
            this.lblsubject.TabIndex = 146;
            this.lblsubject.Text = "大题题目：";
            // 
            // txttopics
            // 
            this.txttopics.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txttopics.Location = new System.Drawing.Point(738, 7);
            this.txttopics.Name = "txttopics";
            this.txttopics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttopics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txttopics.Size = new System.Drawing.Size(180, 20);
            this.txttopics.TabIndex = 154;
            this.txttopics.TextChanged += new System.EventHandler(this.txttopics_TextChanged);
            // 
            // lbltype
            // 
            this.lbltype.Location = new System.Drawing.Point(312, 10);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(60, 14);
            this.lbltype.TabIndex = 151;
            this.lbltype.Text = "考题类型：";
            // 
            // lbltopic
            // 
            this.lbltopic.Location = new System.Drawing.Point(648, 10);
            this.lbltopic.Name = "lbltopic";
            this.lbltopic.Size = new System.Drawing.Size(84, 14);
            this.lbltopic.TabIndex = 153;
            this.lbltopic.Text = "需要答案数量：";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(378, 7);
            this.txttype.Name = "txttype";
            this.txttype.Properties.AutoComplete = false;
            this.txttype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txttype.Size = new System.Drawing.Size(180, 20);
            this.txttype.TabIndex = 152;
            this.txttype.TextChanged += new System.EventHandler(this.txttype_TextChanged);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl.Size = new System.Drawing.Size(332, 829);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.xialakuang,
            this.txtyear});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // xialakuang
            // 
            this.xialakuang.Caption = "是否可以写入";
            this.xialakuang.ColumnEdit = this.repositoryItemCheckEdit1;
            this.xialakuang.Name = "xialakuang";
            this.xialakuang.Visible = true;
            this.xialakuang.VisibleIndex = 0;
            this.xialakuang.Width = 86;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // txtyear
            // 
            this.txtyear.Caption = "考题题目";
            this.txtyear.FieldName = "txtyear";
            this.txtyear.Name = "txtyear";
            this.txtyear.OptionsColumn.AllowEdit = false;
            this.txtyear.Visible = true;
            this.txtyear.VisibleIndex = 1;
            this.txtyear.Width = 223;
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
            this.btnall,
            this.btndelete,
            this.btnaddto,
            this.btnRefrest,
            this.btnCencel,
            this.btnPreservation});
            this.barManager.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPreservation),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnaddto),
            new DevExpress.XtraBars.LinkPersistInfo(this.btndelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefrest),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCencel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnall)});
            this.bar1.Text = "Tools";
            // 
            // btnPreservation
            // 
            this.btnPreservation.Caption = "保存该题";
            this.btnPreservation.Id = 5;
            this.btnPreservation.ImageOptions.Image = global::QA.Properties.Resources.btnGetinto_ImageOptions_Image;
            this.btnPreservation.Name = "btnPreservation";
            this.btnPreservation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPreservation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreservation_ItemClick);
            // 
            // btnaddto
            // 
            this.btnaddto.Caption = "添加题目";
            this.btnaddto.Id = 2;
            this.btnaddto.ImageOptions.Image = global::QA.Properties.Resources.btnAddtype_ImageOptions_Image;
            this.btnaddto.Name = "btnaddto";
            this.btnaddto.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btndelete
            // 
            this.btndelete.Caption = "删除该题";
            this.btndelete.Id = 1;
            this.btndelete.ImageOptions.Image = global::QA.Properties.Resources.btnDeletetype_ImageOptions_Image;
            this.btndelete.Name = "btndelete";
            this.btndelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btndelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndelete_ItemClick);
            // 
            // btnRefrest
            // 
            this.btnRefrest.Caption = "刷新";
            this.btnRefrest.Id = 3;
            this.btnRefrest.ImageOptions.Image = global::QA.Properties.Resources.btnRefrest_ImageOptions_Image;
            this.btnRefrest.Name = "btnRefrest";
            this.btnRefrest.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefrest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefrest_ItemClick);
            // 
            // btnCencel
            // 
            this.btnCencel.Caption = "取消修改";
            this.btnCencel.Id = 4;
            this.btnCencel.ImageOptions.Image = global::QA.Properties.Resources.btnEdittype_ImageOptions_Image;
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnall
            // 
            this.btnall.Caption = "全部提交";
            this.btnall.Id = 0;
            this.btnall.ImageOptions.Image = global::QA.Properties.Resources.btnEdits_ImageOptions_Image;
            this.btnall.Name = "btnall";
            this.btnall.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnall.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnall_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1715, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 873);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1715, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 833);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1715, 40);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 833);
            // 
            // FrmTeacherUserImportAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 873);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTeacherUserImportAnswer";
            this.Text = "答案";
            this.Load += new System.EventHandler(this.FrmTeacherUserImportAnswer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttopics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnall;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnaddto;
        private DevExpress.XtraBars.BarButtonItem btnRefrest;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn txtyear;
        private Kuade.WinControls.ExtOptions extOptions;
        private DevExpress.XtraEditors.SpinEdit txttopics;
        private DevExpress.XtraEditors.LabelControl lbltopic;
        private DevExpress.XtraEditors.ComboBoxEdit txttype;
        private DevExpress.XtraEditors.LabelControl lbltype;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private DevExpress.XtraEditors.LabelControl lblsubject;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btnCencel;
        private DevExpress.XtraBars.BarButtonItem btnPreservation;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn xialakuang;
    }
}