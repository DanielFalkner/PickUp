using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace PickUpApp.Models
{
    internal class DeliveryOverview
    {
        private Status status;
        private Location location;
        private DateTime estimatedDelivery;
        private List<Delivery> deliveries;
    }
}
