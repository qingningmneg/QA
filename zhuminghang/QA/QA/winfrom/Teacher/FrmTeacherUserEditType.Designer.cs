
namespace QA.winfrom
{
    partial class FrmTeacherUserEditType
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
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAddtype = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdittype = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeletetype = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefrest = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.exam_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.btnAddtype,
            this.btnEdittype,
            this.btnDeletetype,
            this.btnRefrest});
            this.barManager.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddtype),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdittype),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeletetype),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefrest)});
            this.bar1.Text = "Tools";
            // 
            // btnAddtype
            // 
            this.btnAddtype.Caption = "添加类型";
            this.btnAddtype.Id = 0;
            this.btnAddtype.ImageOptions.Image = global::QA.Properties.Resources.btnAddtype_ImageOptions_Image;
            this.btnAddtype.Name = "btnAddtype";
            this.btnAddtype.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddtype.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddtype_ItemClick);
            // 
            // btnEdittype
            // 
            this.btnEdittype.Caption = "编辑类型";
            this.btnEdittype.Id = 1;
            this.btnEdittype.ImageOptions.Image = global::QA.Properties.Resources.btnEdittype_ImageOptions_Image;
            this.btnEdittype.Name = "btnEdittype";
            this.btnEdittype.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdittype.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdittype_ItemClick);
            // 
            // btnDeletetype
            // 
            this.btnDeletetype.Caption = "删除类型";
            this.btnDeletetype.Id = 2;
            this.btnDeletetype.ImageOptions.Image = global::QA.Properties.Resources.btnDeletetype_ImageOptions_Image;
            this.btnDeletetype.Name = "btnDeletetype";
            this.btnDeletetype.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDeletetype.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeletetype_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(1416, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 706);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(1416, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 666);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1416, 40);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 666);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exam_type,
            this.guid});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1416, 666);
            this.dataGridView.TabIndex = 67;
            // 
            // exam_type
            // 
            this.exam_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exam_type.DataPropertyName = "exam_type";
            this.exam_type.HeaderText = "目前类型";
            this.exam_type.Name = "exam_type";
            this.exam_type.ReadOnly = true;
            // 
            // guid
            // 
            this.guid.DataPropertyName = "guid";
            this.guid.HeaderText = "guid";
            this.guid.Name = "guid";
            this.guid.ReadOnly = true;
            this.guid.Visible = false;
            // 
            // FrmTeacherUserEditType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 706);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTeacherUserEditType";
            this.Text = "编辑类型";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTeacherUserEditType_FormClosed);
            this.Load += new System.EventHandler(this.FrmTeacherUserEditType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAddtype;
        private DevExpress.XtraBars.BarButtonItem btnEdittype;
        private DevExpress.XtraBars.BarButtonItem btnDeletetype;
        private DevExpress.XtraBars.BarButtonItem btnRefrest;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
    }
}