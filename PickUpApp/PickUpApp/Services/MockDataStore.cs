using PickUpApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PickUpApp.Services
{
    public class MockDataStore : IDataStore<Delivery>
    {
        List<Delivery> items;
       // List<Delivery> selectedItems;
        List<Station> stations;



        public MockDataStore()
        {
            items = new List<Delivery>()
            {
                //Hallo...
                new Delivery("1036", new Person("Zalando", "a.b@abc.com", 321, 999, new Xamarin.Essentials.Location()), 
                             new Person("Receiver", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             3.0, Size.Groß, new QRCoder.QRCode(), Status.auftretende_Probleme, new Xamarin.Essentials.Location(), DateTime.Now),
                new Delivery("2456", new Person("Amazon", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             new Person("Receiver", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             3.0, Size.Mittel, new QRCoder.QRCode(), Status.Zugestellt, new Xamarin.Essentials.Location(), DateTime.MinValue),
                new Delivery("1834", new Person("Muster GmbH", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             new Person("Receiver", "muster@gmx.com", 123, 123, new Xamarin.Essentials.Location()),
                             3.0, Size.Klein, new QRCoder.QRCode(), Status.In_Bearbeitung, new Xamarin.Essentials.Location(), DateTime.MaxValue),
                new Delivery("2029", new Person("Muster GmbH", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             new Person("Receiver", "muster@gmx.com", 123, 123, new Xamarin.Essentials.Location()),
                             3.0, Size.Klein, new QRCoder.QRCode(), Status.Versendet, new Xamarin.Essentials.Location(), new DateTime(2022, 8, 2, 12, 0, 0, 0)),
                new Delivery("4032", new Person("Muster GmbH", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             new Person("Receiver", "muster@gmx.com", 123, 123, new Xamarin.Essentials.Location()),
                             3.0, Size.Klein, new QRCoder.QRCode(), Status.Versendet, new Xamarin.Essentials.Location(), new DateTime(2022, 9, 3, 12, 0, 0, 0)),
                new Delivery("5051", new Person("Muster GmbH", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             new Person("Receiver", "muster@gmx.com", 123, 123, new Xamarin.Essentials.Location()),
                             3.0, Size.Klein, new QRCoder.QRCode(), Status.Versendet, new Xamarin.Essentials.Location(), new DateTime(2022, 1, 3, 12, 0, 0, 0)),
                new Delivery("2890", new Person("Muster GmbH", "a.b@abc.com", 123, 123, new Xamarin.Essentials.Location()),
                             new Person("Receiver", "muster@gmx.com", 123, 123, new Xamarin.Essentials.Location()),
                             3.0, Size.Klein, new QRCoder.QRCode(), Status.Versendet, new Xamarin.Essentials.Location(), new DateTime(2022, 9, 3, 12, 0, 0, 0))
                /*
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }*/
            };

          /*  selectedItems = new List<Delivery>();
            AddItemByStringAsync("103647785543");
            AddItemByStringAsync("245632876433");*/

            stations = new List<Station>()
            {
                new Station(1, "Abholstation 4020", "48.303723880697106, 14.293336868540937", 48.3037238, 14.2933368),
                new Station(2, "Abholstation 4040", "48.33612015604028, 14.31245863183628", 48.3361201, 14.3124586),
                new Station(3, "Abholstation 4030", "48.258576817930646, 14.290852730776692", 48.2585768, 14.2908527)
            };
        }

        public List<Station> GetStations()
        {
            return stations;
        }

        public List<Delivery> GetDeliveries()
        {
            return items;
        }

        public async Task<bool> AddItemAsync(Delivery item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }
        //Add existing item from Database
       /* public async Task<bool> AddItemByStringAsync(string id)
        {
            foreach (Delivery item in items)
            {
                if (item.Id == id)
                {
                    selectedItems.Add(item);
                }
            }

      
            return await Task.FromResult(true);
        }*/

        //for returnBox
        public async Task<IEnumerable<Delivery>> GetDeliveriesAsync()
        {
            return await Task.FromResult(items);
        }


       /* public async Task<IEnumerable<Delivery>> GetItemsSelectedAsync()
        {
            return await Task.FromResult(selectedItems);
        }*/


        public async Task<bool> UpdateItemAsync(Delivery item)
        {
            var oldItem = items.Where((Delivery arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Delivery arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Delivery> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Delivery>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}