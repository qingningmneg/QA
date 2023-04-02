
namespace QA.winfrom
{
    partial class FrmTeacherUserEditYear
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
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.txtStartTime = new DevExpress.XtraEditors.DateEdit();
            this.txtEndTime = new DevExpress.XtraEditors.DateEdit();
            this.lblLine = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.btnpreservation = new DevExpress.XtraEditors.SimpleButton();
            this.btnCencel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(55, 102);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(76, 14);
            this.lblStartTime.TabIndex = 35;
            this.lblStartTime.Text = "考试开始时间:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.EditValue = null;
            this.txtStartTime.Location = new System.Drawing.Point(137, 99);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartTime.Size = new System.Drawing.Size(146, 20);
            this.txtStartTime.TabIndex = 36;
            // 
            // txtEndTime
            // 
            this.txtEndTime.EditValue = null;
            this.txtEndTime.Location = new System.Drawing.Point(385, 99);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndTime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndTime.Size = new System.Drawing.Size(146, 20);
            this.txtEndTime.TabIndex = 39;
            // 
            // lblLine
            // 
            this.lblLine.Location = new System.Drawing.Point(289, 102);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(8, 14);
            this.lblLine.TabIndex = 37;
            this.lblLine.Text = "--";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(303, 102);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(76, 14);
            this.lblEndTime.TabIndex = 38;
            this.lblEndTime.Text = "考试结束时间:";
            // 
            // btnpreservation
            // 
            this.btnpreservation.Location = new System.Drawing.Point(159, 199);
            this.btnpreservation.Name = "btnpreservation";
            this.btnpreservation.Size = new System.Drawing.Size(75, 23);
            this.btnpreservation.TabIndex = 40;
            this.btnpreservation.Text = "保存";
            this.btnpreservation.Click += new System.EventHandler(this.btnpreservation_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(321, 199);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(75, 23);
            this.btnCencel.TabIndex = 41;
            this.btnCencel.Text = "取消";
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // FrmTeacherUserEditYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 300);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnpreservation);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblEndTime);
            this.Name = "FrmTeacherUserEditYear";
            this.Text = "编辑年份";
            this.Load += new System.EventHandler(this.FrmTeacherUserEditYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblStartTime;
        private DevExpress.XtraEditors.DateEdit txtStartTime;
        private DevExpress.XtraEditors.DateEdit txtEndTime;
        private DevExpress.XtraEditors.LabelControl lblLine;
        private DevExpress.XtraEditors.LabelControl lblEndTime;
        private DevExpress.XtraEditors.SimpleButton btnpreservation;
        private DevExpress.XtraEditors.SimpleButton btnCencel;
    }
}