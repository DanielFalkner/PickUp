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

        private async void OnReturnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ReturnPage());
        }
    }
}