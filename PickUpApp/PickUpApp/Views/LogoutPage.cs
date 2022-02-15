using Microsoft.Identity.Client;
using Xamarin.Forms;

namespace PickUpApp.Views
{
    internal class LogoutPage : Page
    {
        private AuthenticationResult result;

        public LogoutPage(AuthenticationResult result)
        {
            this.result = result;
        }
    }
}