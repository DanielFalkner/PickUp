using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;


namespace PickUpApp.Models
{
    internal class Person
    {
        private string name;
        private string mail;
        private long telNr;
        private Location location;
        private double credit;
        private List<Delivery> deliveries;

        public Person(string name, string mail, long telNr, double credit, Location location)
        {
            this.name = name;
            this.mail = mail;
            this.telNr = telNr;
            this.credit = credit;
            this.Location = location;
            this.deliveries = new List<Delivery>();
        }

        public string Name { get => name; set => name = value; }
        public string Mail { get => mail; set => mail = value; }
        public long TelNr { get => telNr; set => telNr = value; }
        public double Credit { get => credit; set => credit = value; }
        public Location Location { get => location; set => location = value; }



        public void giveUp(Delivery delivery)
        {
            
        }
        public void pickUp(Delivery delivery)
        {

        }

        public double changeCerdit()
        {
            return 0.0;
        }

        public Station findNearestAvailableStation(Size size)
        {
            return null;
        }

        public void returnBox(Station station)
        {

        }

    }


}
    
   
     
