using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WinApp.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            txtUserNo.Text = "ningmeng";
            txtUserPwd.Text = "123456";
            var user_no = this.txtUserNo.Text;
            var user_pwd = this.txtUserPwd.Text;
            if (user_no == null || user_no == "")
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "用户名不能为空！", "OK"); });
                return;
            }
            if (user_pwd == null || user_no == "")
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "密码不能为空！", "OK"); });
                return;
            }
            var dt = $"select * from UserInfo where user_no=@user_no and user_pwd =@user_pwd".EQ(("@user_no", user_no), ("@user_pwd", user_pwd));
            if (dt != null && dt.Rows.Count > 0)
            {
                var dr = dt.Rows[0];
                App.user_no = Convert.ToString(dr["user_no"]);
                Navigation.PushModalAsync(new Frmscan());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "用户名或者密码错误！", "OK"); });
                return;
            }
        }

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FrmRegister());
        }

        private void txtUserNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var user_no = this.txtUserNo.Text.Trim();

            //var dt = $"select * from UserInfo where user_no=@user_no".EQ(("@user_no", user_no));
            //if (dt != null && dt.Rows.Count > 0)
            //{

            //}
        }
    }
}