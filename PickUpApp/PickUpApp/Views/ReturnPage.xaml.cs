using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickUpApp.Views
{
    using Xamarin.Essentials;
    using Xamarin.Forms;
    public partial class ReturnPage : ContentPage
    {
        public ReturnPage()
        {
            InitializeComponent();
        }

        private async void OnStationClicked(object sender, EventArgs e)
        {
            Grid2.IsVisible = false;
            Grid1.IsVisible = true;

            if (Device.RuntimePlatform == Device.Android)
            {
                await Launcher.OpenAsync("https://www.google.com/maps?saddr=Lentos,+4020+Linz&daddr=Post+Abholstation+A");
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                await Launcher.OpenAsync("http://maps.apple.com/?daddr=Post+Abholstation+A,+CA&saddr=Lentos,+4020+Linz");
            }
        }

        private void OnDeliveryClicked(object sender, EventArgs e)
        {
            Grid2.IsVisible = true;
            Grid1.IsVisible = false;
        }
    }
}