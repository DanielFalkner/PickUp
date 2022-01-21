using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;


namespace PickUpApp.Models
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

    }


}
    
   
     
