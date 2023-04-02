using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ZXing.Net.Mobile.Forms;

namespace WinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Frmscan : ContentPage
    {
        public Frmscan()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 扫一扫点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            var options = new ZXing.Mobile.MobileBarcodeScanningOptions
            {
                PossibleFormats = new List<ZXing.BarcodeFormat>
                {
                    ZXing.BarcodeFormat.QR_CODE,
                }
            };

            var scanPage = new ZXingScannerPage(options);

            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Task<bool> a = null;
                Device.BeginInvokeOnMainThread(() =>
                {
                    a = DisplayAlert("提示", "是否确认登陆", "确定", "取消");
                });

                while (a == null)
                {
                }

                if (a != null && a.Result == true)
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PopModalAsync();
                        var barcode = result.Text;
                        {
                            var dt = SqlHelper.EQ($@"select * from BarCodeInfo where barcode=@barcode", ("@barcode", barcode));
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                SqlHelper.EQ($@"update BarCodeInfo set user_no = @user_no where barcode = @barcode", ("@user_no", App.user_no), ("@barcode", barcode));

                                await DisplayAlert("Scanned Barcode", "登陆成功！", "OK");
                            }
                        }
                    });
                }
            };
            await Navigation.PushModalAsync(scanPage);
        }

        /// <summary>
        /// 考试点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnExamination_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new FrmWrongQuestion());
        }

        /// <summary>
        /// 点击错题集按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnWrongQuestion_Clicked(object sender, EventArgs e)
        {


        }
       
    }
}