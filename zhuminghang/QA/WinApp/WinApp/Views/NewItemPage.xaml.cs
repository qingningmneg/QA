using System;
using System.Collections.Generic;
using System.ComponentModel;
using WinApp.Models;
using WinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WinApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}