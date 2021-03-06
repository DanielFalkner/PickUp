using Microsoft.Identity.Client;
using PickUpApp.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickUpApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private AuthenticationResult authenticationResult;
        private ItemsViewModel _viewModel;

        public AboutPage(AuthenticationResult authResult)
        {
            authenticationResult = authResult;
            var name = authenticationResult.Account.Username;
            InitializeComponent();

        }

        private async void OnReturnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ReturnPage());
        }

        private void OnItemsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsPage());
        }

        private async void OnNewItemPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage(_viewModel)); // viewModel handed over to make the access possible to the ItemList
        }
    }
}