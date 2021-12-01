using System;
using System.Collections.Generic;
using System.Text;

namespace PickUpApp.Models
{
    internal class Person
    {
        private string name;
        private string mail;
        private long telNr;
        private double credit;

        //constructor
        public Person(string name) { }
        public Person(string name, string mail) { }
        public Person(string name, string mail, long telNr) { }

        //string name { get; set; }
        //public string mail { get; set; }
        //public long telNr { get; set; }
        //location
        //public double credit { get; set; }
        //delivery (list)

    }
}
