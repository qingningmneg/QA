
namespace QA.winfrom
{
    partial class FrmUserLoginQrcode
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
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator2 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barCodeControl = new DevExpress.XtraEditors.BarCodeControl();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(123, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(154, 17);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "使用手机扫一扫进行登录";
            // 
            // barCodeControl
            // 
            this.barCodeControl.AutoModule = true;
            this.barCodeControl.Location = new System.Drawing.Point(53, 75);
            this.barCodeControl.Name = "barCodeControl";
            this.barCodeControl.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl.ShowText = false;
            this.barCodeControl.Size = new System.Drawing.Size(292, 280);
            qrCodeGenerator2.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte;
            qrCodeGenerator2.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.H;
            qrCodeGenerator2.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.barCodeControl.Symbology = qrCodeGenerator2;
            this.barCodeControl.TabIndex = 11;
            // 
            // time
            // 
            this.time.Interval = 500;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 50000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmUserLoginQrcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 372);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barCodeControl);
            this.Name = "FrmUserLoginQrcode";
            this.Text = "扫码登录";
            this.Load += new System.EventHandler(this.FrmUserLoginQrcode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Timer timer;
    }
}