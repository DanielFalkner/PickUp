﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace PickUpApp.Models
{
    public class Station : Location
    {
        //private Map<Size, amount> place;
        private int id;
        private string name;
        private String coordinates;
        double latitude;
        double longitude;
         
        // "base" works like "super" in Java 
        public Station (int id, String name, String coordinates, double latitude, double longitude) : base() { 
            this.id = id;
            this.name = name;
            this.coordinates = coordinates;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public int Id { get => id; set => id = value; }

        public String getCoordinates()
        {
            return coordinates;
        }

        public double getLatitude()
        {
            return latitude;
        }

        public double getLongitude()
        {
            return longitude;
        }

    }
}
