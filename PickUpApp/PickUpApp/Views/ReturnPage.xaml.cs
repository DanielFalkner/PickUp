using PickUpApp.Models;
using PickUpApp.Services;
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

        public ReturnPage()
        {
            InitializeComponent();
        }

        //not possible on emulator
        private async void OnStationClicked(object sender, EventArgs e)
        {
            Geocoder geoCoder = new Geocoder();

            IEnumerable<Position> approximateLocations = await geoCoder.GetPositionsForAddressAsync("Lentos, Linz, Österreich");
            Position startPosition = approximateLocations.FirstOrDefault();
            string coordinates = $"{startPosition.Latitude}, {startPosition.Longitude}";

            Station station = FindNearestStation(coordinates);

            Debug.WriteLine("TEST " + station.getName() + " TEST");

            //formats coordinates into address. not needed at the moment

//            Position endPosition = new Position(station.getLatitude(), station.getLatitude());
//            IEnumerable<string> possibleAddresses = await geoCoder.GetAddressesForPositionAsync(endPosition);
//            string address = possibleAddresses.FirstOrDefault();

//            Debug.WriteLine("TEST " + address + " TEST");

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

        private Station FindNearestStation(String demoCoordinates)
        {
            List<Station> stations = dataStore.GetStations();
            int r = rnd.Next(stations.Count);
            
            return stations[r];
        }

        private void OnDeliveryClicked(object sender, EventArgs e)
        {
            Grid2.IsVisible = true;
            Grid1.IsVisible = false;
        }
    }
}