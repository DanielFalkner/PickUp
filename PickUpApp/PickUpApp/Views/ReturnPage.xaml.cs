using PickUpApp.Models;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PickUpApp.Views
{
    public partial class ReturnPage : ContentPage
    {
        public ReturnPage()
        {
            InitializeComponent();
        }

        private async void OnStationClicked(object sender, EventArgs e)
        {
            Geocoder geoCoder = new Geocoder();

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

        private void CreatePersonClicked(object sender, EventArgs e)
        {
            Person person = new Person(entry.Text);
//          testLabel.SetValue(person.Name);
        }
    }
}