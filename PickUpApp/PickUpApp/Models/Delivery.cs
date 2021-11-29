using QRCoder;
using System;
using System.Collections.Generic;
using System.Text;

namespace PickUpApp.Models
{
    internal class Delivery
    {
        private int id;
        private Person sneder;
        private Station receiver;
        private double weight;
        private Size size;
        private QRCode QRCode;

        public Delivery(int id, Person sneder, Station receiver, double weight, Size size, QRCode qRCode)
        {
            this.id = id;
            this.sneder = sneder;
            this.receiver = receiver;
            this.weight = weight;
            this.size = size;
            QRCode = qRCode;
        }

        public int Id { get => id; set => id = value; }
        public Station Receiver { get => receiver; set => receiver = value; }
        public double Weight { get => weight; set => weight = value; }
        public QRCode QRCode1 { get => QRCode; set => QRCode = value; }
        internal Person Sneder { get => sneder; set => sneder = value; }
        internal Size Size { get => size; set => size = value; }

    }
}
