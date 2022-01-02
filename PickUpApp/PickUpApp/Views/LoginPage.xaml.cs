using PickUpApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PickUpApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(Email.Text == "admin" && Password.Text == "admin")
            {
                Navigation.PushAsync(new AboutPage());
            }
            else
            {
                DisplayAlert("LoginErrorMessage", "Username or Password incorrect","Okay");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewItemPage());
        }
    }
}