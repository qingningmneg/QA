
namespace QA.winfrom
{
    partial class FrmTeachUserEditPosition
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
            this.lbltype = new DevExpress.XtraEditors.LabelControl();
            this.txttype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnnextstep = new DevExpress.XtraEditors.SimpleButton();
            this.btnCencel = new DevExpress.XtraEditors.SimpleButton();
            this.lbladd = new DevExpress.XtraEditors.SimpleButton();
            this.lblYesorNo = new DevExpress.XtraEditors.LabelControl();
            this.txtyearText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtyear = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyearText.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtyear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltype
            // 
            this.lbltype.Location = new System.Drawing.Point(98, 12);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(52, 14);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "题目类型:";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(156, 9);
            this.txttype.Name = "txttype";
            this.txttype.Properties.AutoComplete = false;
            this.txttype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txttype.Size = new System.Drawing.Size(290, 20);
            this.txttype.TabIndex = 58;
            // 
            // btnnextstep
            // 
            this.btnnextstep.Location = new System.Drawing.Point(212, 28);
            this.btnnextstep.Name = "btnnextstep";
            this.btnnextstep.Size = new System.Drawing.Size(75, 25);
            this.btnnextstep.TabIndex = 59;
            this.btnnextstep.Text = "下一步";
            this.btnnextstep.Click += new System.EventHandler(this.btnnextstep_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(317, 28);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(75, 25);
            this.btnCencel.TabIndex = 60;
            this.btnCencel.Text = "取消";
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // lbladd
            // 
            this.lbladd.Location = new System.Drawing.Point(452, 8);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(75, 23);
            this.lbladd.TabIndex = 61;
            this.lbladd.Text = "添加类型";
            this.lbladd.Click += new System.EventHandler(this.lbladd_Click);
            // 
            // lblYesorNo
            // 
            this.lblYesorNo.Location = new System.Drawing.Point(98, 63);
            this.lblYesorNo.Name = "lblYesorNo";
            this.lblYesorNo.Size = new System.Drawing.Size(40, 14);
            this.lblYesorNo.TabIndex = 62;
            this.lblYesorNo.Text = "是否以:";
            // 
            // txtyearText
            // 
            this.txtyearText.Location = new System.Drawing.Point(156, 60);
            this.txtyearText.Name = "txtyearText";
            this.txtyearText.Size = new System.Drawing.Size(290, 20);
            this.txtyearText.TabIndex = 63;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(453, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 14);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "为年份名称:";
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Location = new System.Drawing.Point(250, 86);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(37, 18);
            this.radYes.TabIndex = 65;
            this.radYes.TabStop = true;
            this.radYes.Text = "是";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(317, 86);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(37, 18);
            this.radNo.TabIndex = 66;
            this.radNo.TabStop = true;
            this.radNo.Text = "否";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtyear);
            this.panel1.Controls.Add(this.txtyearText);
            this.panel1.Controls.Add(this.radNo);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.radYes);
            this.panel1.Controls.Add(this.txttype);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lbladd);
            this.panel1.Controls.Add(this.lblYesorNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 148);
            this.panel1.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCencel);
            this.panel2.Controls.Add(this.btnnextstep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 65);
            this.panel2.TabIndex = 68;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(156, 125);
            this.txtyear.Name = "txtyear";
            this.txtyear.Properties.AutoComplete = false;
            this.txtyear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtyear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtyear.Size = new System.Drawing.Size(290, 20);
            this.txtyear.TabIndex = 67;
            // 
            // FrmTeachUserEditPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 219);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTeachUserEditPosition";
            this.Text = "题目位置";
            this.Load += new System.EventHandler(this.FrmTeachUserEditPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyearText.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtyear.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbltype;
        private DevExpress.XtraEditors.ComboBoxEdit txttype;
        private DevExpress.XtraEditors.SimpleButton btnnextstep;
        private DevExpress.XtraEditors.SimpleButton btnCencel;
        private DevExpress.XtraEditors.SimpleButton lbladd;
        private DevExpress.XtraEditors.LabelControl lblYesorNo;
        private DevExpress.XtraEditors.TextEdit txtyearText;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ComboBoxEdit txtyear;
    }
}