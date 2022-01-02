﻿using PickUpApp.Services;
using PickUpApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickUpApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
