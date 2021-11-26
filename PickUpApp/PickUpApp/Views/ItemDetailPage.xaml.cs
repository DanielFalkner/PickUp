using PickUpApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PickUpApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}