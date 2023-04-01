using System;
using WinApp.Services;
using WinApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WinApp
{
    public partial class App : Application
    {
        public static string user_no = "";
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
