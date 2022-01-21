using PickUpApp.Models;
using PickUpApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickUpApp.Views
{
    public partial class NewItemPage : ContentPage
    {

        public NewItemPage(ItemsViewModel itemsViewModel)
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel(itemsViewModel);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(this);
        }
    }
}