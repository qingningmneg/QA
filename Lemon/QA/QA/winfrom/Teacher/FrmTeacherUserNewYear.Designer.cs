
namespace QA.winfrom
{
    partial class FrmTeacherUserNewYear
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.exam_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltypeText = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbltype = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdityear = new DevExpress.XtraEditors.SimpleButton();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.btnrefrest = new DevExpress.XtraEditors.SimpleButton();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.lblLine = new DevExpress.XtraEditors.LabelControl();
            this.txtEndTime = new DevExpress.XtraEditors.DateEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtStartTime = new DevExpress.XtraEditors.DateEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSelect = new DevExpress.XtraEditors.TextEdit();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbltypeText.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSelect.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exam_time,
            this.guid,
            this.delete});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1402, 653);
            this.dataGridView.TabIndex = 36;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // exam_time
            // 
            this.exam_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exam_time.DataPropertyName = "exam_time";
            this.exam_time.HeaderText = "考试时间";
            this.exam_time.Name = "exam_time";
            this.exam_time.ReadOnly = true;
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
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 46);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbltypeText);
            this.panel2.Controls.Add(this.lbltype);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 45);
            this.panel2.TabIndex = 38;
            // 
            // lbltypeText
            // 
            this.lbltypeText.Location = new System.Drawing.Point(69, 11);
            this.lbltypeText.Name = "lbltypeText";
            this.lbltypeText.Properties.AutoComplete = false;
            this.lbltypeText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lbltypeText.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.lbltypeText.Size = new System.Drawing.Size(232, 20);
            this.lbltypeText.TabIndex = 58;
            this.lbltypeText.SelectedIndexChanged += new System.EventHandler(this.lbltypeText_SelectedIndexChanged);
            // 
            // lbltype
            // 
            this.lbltype.Location = new System.Drawing.Point(11, 14);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(52, 14);
            this.lbltype.TabIndex = 0;
            this.lbltype.Text = "考题科目:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnEdityear);
            this.panel3.Controls.Add(this.lblStartTime);
            this.panel3.Controls.Add(this.btnrefrest);
            this.panel3.Controls.Add(this.lblEndTime);
            this.panel3.Controls.Add(this.lblLine);
            this.panel3.Controls.Add(this.txtEndTime);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtStartTime);
            this.panel3.Location = new System.Drawing.Point(332, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 45);
            this.panel3.TabIndex = 38;
            // 
            // btnEdityear
            // 
            this.btnEdityear.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdityear.Appearance.Options.UseForeColor = true;
            this.btnEdityear.Location = new System.Drawing.Point(704, 11);
            this.btnEdityear.Name = "btnEdityear";
            this.btnEdityear.Size = new System.Drawing.Size(93, 22);
            this.btnEdityear.TabIndex = 61;
            this.btnEdityear.Text = "编辑科目年份";
            this.btnEdityear.Click += new System.EventHandler(this.btnEdityear_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(7, 15);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(76, 14);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "考试开始时间:";
            // 
            // btnrefrest
            // 
            this.btnrefrest.Location = new System.Drawing.Point(605, 12);
            this.btnrefrest.Name = "btnrefrest";
            this.btnrefrest.Size = new System.Drawing.Size(93, 22);
            this.btnrefrest.TabIndex = 60;
            this.btnrefrest.Text = "刷新";
            this.btnrefrest.Click += new System.EventHandler(this.btnrefrest_Click);
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(271, 15);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(76, 14);
            this.lblEndTime.TabIndex = 33;
            this.lblEndTime.Text = "考试结束时间:";
            // 
            // lblLine
            // 
            this.lblLine.Location = new System.Drawing.Point(257, 15);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(8, 14);
            this.lblLine.TabIndex = 32;
            this.lblLine.Text = "--";
            // 
            // txtEndTime
            // 
            this.txtEndTime.EditValue = null;
            this.txtEndTime.Location = new System.Drawing.Point(353, 12);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndTime.Size = new System.Drawing.Size(146, 20);
            this.txtEndTime.TabIndex = 34;
            this.txtEndTime.EditValueChanged += new System.EventHandler(this.txtEndTime_EditValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(506, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加科目信息";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStartTime
            // 
            this.txtStartTime.EditValue = null;
            this.txtStartTime.Location = new System.Drawing.Point(105, 12);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartTime.Size = new System.Drawing.Size(146, 20);
            this.txtStartTime.TabIndex = 31;
            this.txtStartTime.EditValueChanged += new System.EventHandler(this.txtStartTime_EditValueChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSelect);
            this.panel4.Controls.Add(this.txtSelect);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(816, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 43);
            this.panel4.TabIndex = 39;
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(3, 11);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(150, 20);
            this.txtSelect.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(164, 9);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 38;
            this.btnSelect.Text = "搜索";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmTeacherUserNewYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 699);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTeacherUserNewYear";
            this.Text = "新建科目信息";
            this.Load += new System.EventHandler(this.FrmTeacherUserNewYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbltypeText.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSelect.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn guid;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnEdityear;
        private DevExpress.XtraEditors.LabelControl lblStartTime;
        private DevExpress.XtraEditors.SimpleButton btnrefrest;
        private DevExpress.XtraEditors.DateEdit txtStartTime;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.ComboBoxEdit lbltypeText;
        private DevExpress.XtraEditors.DateEdit txtEndTime;
        private DevExpress.XtraEditors.LabelControl lbltype;
        private DevExpress.XtraEditors.LabelControl lblLine;
        private DevExpress.XtraEditors.LabelControl lblEndTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSelect;
        private DevExpress.XtraEditors.TextEdit txtSelect;
    }
}