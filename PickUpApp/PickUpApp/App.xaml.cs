﻿using Microsoft.Identity.Client;
using Microsoft.Azure.Services.AppAuthentication;
using PickUpApp.Services;
using PickUpApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickUpApp
{
    public partial class App : Application
    {
        public static IPublicClientApplication AuthenticationClient { get; private set; }
        public static object UIParent { get; set; } = null;

        public App()
        {
            InitializeComponent();

            AuthenticationClient = PublicClientApplicationBuilder.Create(Constants.clientId)
                .WithIosKeychainSecurityGroup(Constants.IosKeychainSecurityGroups)
                .WithB2CAuthority(Constants.policySignin)
                .WithRedirectUri($"msal{Constants.clientId}://auth")
                .Build();
           
           
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
