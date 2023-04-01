
namespace QA
{
    partial class FrmStudentExamination
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblload = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblUserText = new DevExpress.XtraEditors.LabelControl();
            this.btnlower = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowsubject = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblsubject = new System.Windows.Forms.Label();
            this.btnWrongquestionbank = new DevExpress.XtraEditors.CheckEdit();
            this.studentExtOptions = new Kuade.WinControls.Student.StudentExtOptions();
            this.panel1.SuspendLayout();
            this.FlowLayout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWrongquestionbank.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnWrongquestionbank);
            this.panel1.Controls.Add(this.lblload);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.lblUserText);
            this.panel1.Controls.Add(this.btnlower);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 43);
            this.panel1.TabIndex = 0;
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Location = new System.Drawing.Point(813, 15);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(43, 14);
            this.lblload.TabIndex = 4;
            this.lblload.Text = "加载中";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(183, 14);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(43, 14);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "第几题";
            // 
            // lblUserText
            // 
            this.lblUserText.Location = new System.Drawing.Point(585, 14);
            this.lblUserText.Name = "lblUserText";
            this.lblUserText.Size = new System.Drawing.Size(48, 14);
            this.lblUserText.TabIndex = 2;
            this.lblUserText.Text = "考试科目";
            // 
            // btnlower
            // 
            this.btnlower.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnlower.Location = new System.Drawing.Point(1262, 0);
            this.btnlower.Name = "btnlower";
            this.btnlower.Size = new System.Drawing.Size(110, 43);
            this.btnlower.TabIndex = 1;
            this.btnlower.Text = "下一题 >";
            this.btnlower.UseVisualStyleBackColor = true;
            this.btnlower.Click += new System.EventHandler(this.btnlower_Click);
            // 
            // btnLast
            // 
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLast.Location = new System.Drawing.Point(0, 0);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(110, 43);
            this.btnLast.TabIndex = 0;
            this.btnLast.Text = "< 上一题";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoSize = true;
            this.FlowLayout.Controls.Add(this.flowsubject);
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlowLayout.Location = new System.Drawing.Point(0, 0);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1372, 6);
            this.FlowLayout.TabIndex = 1;
            // 
            // flowsubject
            // 
            this.flowsubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowsubject.Location = new System.Drawing.Point(3, 3);
            this.flowsubject.Name = "flowsubject";
            this.flowsubject.Size = new System.Drawing.Size(0, 0);
            this.flowsubject.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 714);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.FlowLayout);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1372, 6);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.lblsubject);
            this.panel3.Controls.Add(this.studentExtOptions);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1372, 86);
            this.panel3.TabIndex = 2;
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Location = new System.Drawing.Point(3, 14);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(35, 14);
            this.lblsubject.TabIndex = 1;
            this.lblsubject.Text = "题目:";
            // 
            // btnWrongquestionbank
            // 
            this.btnWrongquestionbank.EditValue = true;
            this.btnWrongquestionbank.Location = new System.Drawing.Point(963, 12);
            this.btnWrongquestionbank.Name = "btnWrongquestionbank";
            this.btnWrongquestionbank.Properties.Caption = "当有错题时不提醒直接存入错题库";
            this.btnWrongquestionbank.Size = new System.Drawing.Size(224, 20);
            this.btnWrongquestionbank.TabIndex = 5;
            // 
            // studentExtOptions
            // 
            this.studentExtOptions.Location = new System.Drawing.Point(45, 4);
            this.studentExtOptions.Margin = new System.Windows.Forms.Padding(4);
            this.studentExtOptions.Name = "studentExtOptions";
            this.studentExtOptions.Size = new System.Drawing.Size(1273, 78);
            this.studentExtOptions.TabIndex = 0;
            // 
            // FrmStudentExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1372, 757);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1260, 789);
            this.Name = "FrmStudentExamination";
            this.Text = "开始考试";
            this.Load += new System.EventHandler(this.FrmStudentExamination_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FlowLayout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnWrongquestionbank.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlower;
        private System.Windows.Forms.Button btnLast;
        private DevExpress.XtraEditors.LabelControl lblUserText;
        public System.Windows.Forms.FlowLayoutPanel FlowLayout;
        public System.Windows.Forms.FlowLayoutPanel flowsubject;
        private Kuade.WinControls.Student.StudentExtOptions studentExtOptions;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblload;
        private System.Windows.Forms.Label lblsubject;
        private DevExpress.XtraEditors.CheckEdit btnWrongquestionbank;
    }
}