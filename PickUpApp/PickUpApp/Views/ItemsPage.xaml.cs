using PickUpApp.Models;
using PickUpApp.ViewModels;
using PickUpApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickUpApp.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private async void OnItemDetailPageClicked(object sender, EventArgs args)
        {
            string button = ((Button)sender).Text;
            await Navigation.PushAsync(new ItemDetailPage(button));
        }
        private async void OnNewItemPageClicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new NewItemPage(_viewModel));
        }

    }
}