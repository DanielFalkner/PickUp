using QRCoder;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace PickUpApp.Models
{
    internal class Delivery
    {
        private int id;
        private Person sender;
        private Person receiver;
        private double weight;
        private Size size;
        private Status status;
        private Location location;
        private DateTime estimatedDelivery;
        private QRCode qrCode;
        private Person detour;
        private string signatureReleaseAuthorization;

        public Delivery(int id, Person sender, Person receiver, double weight, Size size, QRCode qrCode, Status status, Location location, DateTime estimatedDelivery , Person detour = null , string signatureReleaseAuthorization = "")
        {
            this.id = id;
            this.sender = sender;
            this.receiver = receiver;
            this.weight = weight;
            this.size = size;
            this.qrCode = qrCode;
            this.status = status;
            this.location = location;
            this.estimatedDelivery = estimatedDelivery;
            this.detour = detour;
            this.signatureReleaseAuthorization = signatureReleaseAuthorization;
        }

        public int Id { get => id; set => id = value; }
        public Person Receiver { get => receiver; set => receiver = value; }
        public double Weight { get => weight; set => weight = value; }
        public QRCode QRCode { get => qrCode; set => qrCode = value; }
        public Location Location { get => location; set => location = value; }
        public DateTime EstimatedDelivery { get => estimatedDelivery; set => estimatedDelivery = value; }
        public Person Sender { get => sender; set => sender = value; }
        public Size Size { get => size; set => size = value; }
        public Status Status { get => status; set => status = value; }
        public Person Detour { get => detour; set => detour = value; }
        public string SignatureReleaseAuthorization { get => signatureReleaseAuthorization; set => signatureReleaseAuthorization = value; }
    }
}
