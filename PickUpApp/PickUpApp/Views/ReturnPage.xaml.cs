using PickUpApp.Models;
using PickUpApp.Services;
using PickUpApp.ViewModels;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace PickUpApp.Views
{
    public partial class ReturnPage : ContentPage
    {
        MockDataStore dataStore = new MockDataStore();
        static Random rnd = new Random();

        ReturnViewModel _viewModel;

        public ReturnPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ReturnViewModel();
        }

        //not possible on emulator, only on android device (possibly on iOS as well, but not tested yet)
        private async void OnStationClicked(object sender, EventArgs e)
        {
            if (IsPickerSelected())
            {
                Geocoder geoCoder = new Geocoder();

                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;
                var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10000));

                Debug.WriteLine("Position Status: {0}", position.Timestamp);
                Debug.WriteLine("Position Latitude: {0}", position.Latitude);
                Debug.WriteLine("Position Longitude: {0}", position.Longitude);

                string coordinates = position.Latitude.ToString() + ", " + position.Longitude.ToString();

                Station station = FindNearestStation(coordinates, picker.ToString());

                Debug.WriteLine("TEST " + station.getName() + " TEST");

                string route = "https://www.google.com/maps/dir/?api=1&origin=My+Location&destination=" + station.getCoordinates();

                Grid2.IsVisible = false;
                Grid1.IsVisible = true;

                if (Device.RuntimePlatform == Device.Android)
                {
                    await Launcher.OpenAsync(route);
                }
                else if (Device.RuntimePlatform == Device.iOS)
                {
                    await Launcher.OpenAsync(route);
                }
            }
        }

        private Station FindNearestStation(String demoCoordinates, String demoSize)
        {
            List<Station> stations = dataStore.GetStations();
            int r = rnd.Next(stations.Count);
            
            return stations[r];
        }

        private void OnDeliveryClicked(object sender, EventArgs e)
        {
            if (IsPickerSelected())
            {
                Grid2.IsVisible = true;
                Grid1.IsVisible = false;
            }
        }

        private Boolean IsPickerSelected()
        {
            if (picker.SelectedItem == null)
            {
                DisplayAlert("Size Selection", "The size of the box has to be selected", "Okay");
                return false;
            }
            return true;
        }
        //Just temporarly in there for testing; gets replaced
        private async void OnItemDetailPageClicked(object sender, EventArgs args)
        {
            string button = ((Button)sender).Text; // the Text of Button is the ItemId
            await Navigation.PushAsync(new ItemDetailPage(button)); // it is given to the DetailPage
        }
    }
}