using Microsoft.Identity.Client;
using System;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
        public AboutPage(AuthenticationResult authResult)
        {
            authenticationResult = authResult;
            //var name = authenticationResult.Account.Username;
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            GetClaims();
            base.OnAppearing();
        }
        private void GetClaims()
        {
            var token = authenticationResult.IdToken;
            if (token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var data = handler.ReadJwtToken(authenticationResult.IdToken);
                var claims = data.Claims.ToList();
                if (data != null)
                {
                    this.welcome.Text = $"Guten Tag {data.Claims.FirstOrDefault(X => X.Type.Equals("name")).Value} !";
                    //this.issuer.Text = $"Issuer: {data.Claims.FirstOrDefault(x => x.Type.Equals("iss")).Value}";

                }
            }
        }

        async void SignOutBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            await App.AuthenticationClient.RemoveAsync(authenticationResult.Account);
            await Navigation.PushAsync(new LoginPage());
        }

        private async void OnReturnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ReturnPage());
        }

        private void OnItemsButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsPage());
        }


    }
}