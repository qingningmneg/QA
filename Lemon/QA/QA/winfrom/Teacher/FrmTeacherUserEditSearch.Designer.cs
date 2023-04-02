
namespace QA.winfrom
{
    partial class FrmTeacherUserEditSearch
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCenCel = new DevExpress.XtraEditors.SimpleButton();
            this.lblYear = new DevExpress.XtraEditors.LabelControl();
            this.txtUserText = new DevExpress.XtraEditors.TextEdit();
            this.txtyear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbltype = new DevExpress.XtraEditors.LabelControl();
            this.txttype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.subject_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 100000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCenCel);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.txtUserText);
            this.panel1.Controls.Add(this.txtyear);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.txttype);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 70);
            this.panel1.TabIndex = 65;
            // 
            // btnCenCel
            // 
            this.btnCenCel.Location = new System.Drawing.Point(1328, 20);
            this.btnCenCel.Name = "btnCenCel";
            this.btnCenCel.Size = new System.Drawing.Size(75, 23);
            this.btnCenCel.TabIndex = 60;
            this.btnCenCel.Text = "取消";
            this.btnCenCel.Click += new System.EventHandler(this.btnCenCel_Click);
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(181, 24);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(60, 14);
            this.lblYear.TabIndex = 54;
            this.lblYear.Text = "题目年份：";
            // 
            // txtUserText
            // 
            this.txtUserText.Location = new System.Drawing.Point(655, 21);
            this.txtUserText.Name = "txtUserText";
            this.txtUserText.Size = new System.Drawing.Size(586, 20);
            this.txtUserText.TabIndex = 62;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(244, 21);
            this.txtyear.Name = "txtyear";
            this.txtyear.Properties.AutoComplete = false;
            this.txtyear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtyear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtyear.Size = new System.Drawing.Size(303, 20);
            this.txtyear.TabIndex = 55;
            this.txtyear.SelectedIndexChanged += new System.EventHandler(this.txtyear_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(553, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 14);
            this.labelControl1.TabIndex = 61;
            this.labelControl1.Text = "题目内容关键字：";
            // 
            // lbltype
            // 
            this.lbltype.Location = new System.Drawing.Point(11, 24);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(60, 14);
            this.lbltype.TabIndex = 56;
            this.lbltype.Text = "题目类型：";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(77, 21);
            this.txttype.Name = "txttype";
            this.txttype.Properties.AutoComplete = false;
            this.txttype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txttype.Size = new System.Drawing.Size(98, 20);
            this.txttype.TabIndex = 57;
            this.txttype.SelectedIndexChanged += new System.EventHandler(this.txttype_SelectedIndexChanged);
            this.txttype.Click += new System.EventHandler(this.txttype_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(1247, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 59;
            this.btnSelect.Text = "查询";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_content,
            this.guid,
            this.delete});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 90);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1402, 609);
            this.dataGridView.TabIndex = 64;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentDoubleClick);
            // 
            // subject_content
            // 
            this.subject_content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subject_content.DataPropertyName = "subject_content";
            this.subject_content.HeaderText = "内容";
            this.subject_content.Name = "subject_content";
            this.subject_content.ReadOnly = true;
            // 
            // guid
            // 
            this.guid.DataPropertyName = "guid";
            this.guid.HeaderText = "guid";
            this.guid.Name = "guid";
            this.guid.ReadOnly = true;
            this.guid.Visible = false;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "sc";
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // FrmTeacherUserEditSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 699);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeacherUserEditSearch";
            this.Text = "编辑考题";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTeacherUserEditSearch_FormClosed);
            this.Load += new System.EventHandler(this.FrmTeacherUserEditSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnCenCel;
        private DevExpress.XtraEditors.LabelControl lblYear;
        private DevExpress.XtraEditors.TextEdit txtUserText;
        private DevExpress.XtraEditors.ComboBoxEdit txtyear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbltype;
        private DevExpress.XtraEditors.ComboBoxEdit txttype;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}