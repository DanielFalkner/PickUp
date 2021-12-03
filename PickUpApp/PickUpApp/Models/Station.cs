using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace PickUpApp.Models
{
    internal class Station
    {
        //private Map<Size, amount> place;
        private int id;
        private Location location;
        private List<Delivery> deliveries;
        private int availableBoxes;
    }
}
