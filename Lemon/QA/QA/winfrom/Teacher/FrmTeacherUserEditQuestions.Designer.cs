
namespace QA.winfrom
{
    partial class FrmTeacherUserEditQuestions
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
            this.lbltopic = new DevExpress.XtraEditors.LabelControl();
            this.lbltype = new DevExpress.XtraEditors.LabelControl();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnalysis = new DevExpress.XtraEditors.SimpleButton();
            this.btnCenCel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.lblsubject = new DevExpress.XtraEditors.LabelControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.extOptions = new Kuade.WinControls.ExtOptions();
            this.txttopics = new DevExpress.XtraEditors.SpinEdit();
            this.txttype = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txttopics.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltopic
            // 
            this.lbltopic.Location = new System.Drawing.Point(807, 12);
            this.lbltopic.Name = "lbltopic";
            this.lbltopic.Size = new System.Drawing.Size(84, 14);
            this.lbltopic.TabIndex = 143;
            this.lbltopic.Text = "需要答案数量：";
            // 
            // lbltype
            // 
            this.lbltype.Location = new System.Drawing.Point(471, 12);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(60, 14);
            this.lbltype.TabIndex = 141;
            this.lbltype.Text = "考题类型：";
            // 
            // FlowLayout
            // 
            this.FlowLayout.AutoScroll = true;
            this.FlowLayout.Location = new System.Drawing.Point(0, 171);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Size = new System.Drawing.Size(1402, 456);
            this.FlowLayout.TabIndex = 140;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(889, 633);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(208, 57);
            this.btnAnalysis.TabIndex = 139;
            this.btnAnalysis.Text = "编辑题目解析";
            // 
            // btnCenCel
            // 
            this.btnCenCel.Location = new System.Drawing.Point(575, 633);
            this.btnCenCel.Name = "btnCenCel";
            this.btnCenCel.Size = new System.Drawing.Size(208, 57);
            this.btnCenCel.TabIndex = 138;
            this.btnCenCel.Text = "取消修改";
            this.btnCenCel.Click += new System.EventHandler(this.btnCenCel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(268, 633);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(208, 57);
            this.btnSubmit.TabIndex = 137;
            this.btnSubmit.Text = "提交编辑题目";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblsubject
            // 
            this.lblsubject.Location = new System.Drawing.Point(17, 80);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(60, 14);
            this.lblsubject.TabIndex = 136;
            this.lblsubject.Text = "大题题目：";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // extOptions
            // 
            this.extOptions.Location = new System.Drawing.Point(83, 35);
            this.extOptions.Name = "extOptions";
            this.extOptions.Size = new System.Drawing.Size(1307, 130);
            this.extOptions.TabIndex = 145;
            // 
            // txttopics
            // 
            this.txttopics.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txttopics.Location = new System.Drawing.Point(897, 9);
            this.txttopics.Name = "txttopics";
            this.txttopics.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttopics.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txttopics.Size = new System.Drawing.Size(110, 20);
            this.txttopics.TabIndex = 144;
            this.txttopics.TextChanged += new System.EventHandler(this.txttopics_TextChanged);
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(537, 9);
            this.txttype.Name = "txttype";
            this.txttype.Properties.AutoComplete = false;
            this.txttype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txttype.Size = new System.Drawing.Size(135, 20);
            this.txttype.TabIndex = 142;
            // 
            // FrmTeacherUserEditQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 699);
            this.Controls.Add(this.extOptions);
            this.Controls.Add(this.txttopics);
            this.Controls.Add(this.lbltopic);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.FlowLayout);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.btnCenCel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblsubject);
            this.Name = "FrmTeacherUserEditQuestions";
            this.Text = "编辑考题";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTeacherUserEditQuestions_FormClosed);
            this.Load += new System.EventHandler(this.FrmTeacherUserEditQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txttopics.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit txttopics;
        private DevExpress.XtraEditors.LabelControl lbltopic;
        private DevExpress.XtraEditors.ComboBoxEdit txttype;
        private DevExpress.XtraEditors.LabelControl lbltype;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private DevExpress.XtraEditors.SimpleButton btnAnalysis;
        private DevExpress.XtraEditors.SimpleButton btnCenCel;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.LabelControl lblsubject;
        private System.Windows.Forms.Timer timer;
        private Kuade.WinControls.ExtOptions extOptions;
        private System.Windows.Forms.Timer timer1;
    }
}