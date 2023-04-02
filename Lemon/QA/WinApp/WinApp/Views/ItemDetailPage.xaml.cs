using System.ComponentModel;
using WinApp.ViewModels;
using Xamarin.Forms;

namespace WinApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}