using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace PickUpApp.Models
{
    internal class Station : Location
    {
        //private Map<Size, amount> place;
        private int id;
        private List<Delivery> deliveries;
        private int availableBoxes;
         
        // "base" works like "super" in Java 
        public Station (int id , int availablBoxes) : base() { 
            this.id = id;
            this.availableBoxes = availablBoxes;
            this.deliveries = new List<Delivery> ();

         
        }
        public int Id { get => id; set => id = value; }
        public int AvailableBoxes { get => availableBoxes; set => availableBoxes = value; }

        public void GiveIn (Delivery delivery) {
            deliveries.Add(delivery);
        }

        public void PickUp(Delivery delivery)
        {
            deliveries.Remove(delivery);
        }


        //TODO!!
         public void ReturnBox(Delivery delivery)
        {
            deliveries.Add(delivery);
        }
    }
}
