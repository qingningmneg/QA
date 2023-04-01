using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrmRegister : ContentPage
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            var user_no = this.txtUserNo.Text;
            var user_pwd = this.txtUserPwd.Text;
            var user_re_pwd = this.txtReUserPwd.Text;
            var user_name = this.txtUserName.Text;
            if (user_no == null)
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "用户名不能为空！", "OK"); });
                return;
            }
            if (user_pwd == null)
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "密码不能为空！", "OK"); });
                return;
            }
            if (user_re_pwd != user_pwd)
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "两次密码不一致！", "OK"); });
                return;
            }
            if (user_name == null)
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "用户姓名不能为空！", "OK"); });
                return;
            }
            var dt = $@"select * from UserInfo where user_no=@user_no".EQ(("@user_no", user_no));
            if (dt != null && dt.Rows.Count > 0)
            {
                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "用户名已存在！", "OK"); });
                return;
            }
            else
            {
                $@"insert into UserInfo (user_no,user_pwd,user_name)values(@user_no,@user_pwd,@user_name)".ENQ(("@user_no", user_no, typeof(string).FullName), ("@user_pwd", user_pwd, typeof(string).FullName),("@user_name",user_name,typeof(string).FullName));

                Device.BeginInvokeOnMainThread(async () => { await DisplayAlert("Scanned Barcode", "注册成功！", "OK"); });
                Navigation.PopModalAsync();
            }
        }

        private void btnCencel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}