using DevExpress.Data.XtraReports.Native;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.FSharp.Linq.RuntimeHelpers;
using PickUpApp.Models;
using PickUpApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace PickUpApp.ViewModels
{
    public class ReturnViewModel : BindableObject
    {
        public ObservableCollection<Delivery> Delivery = new ObservableCollection<Delivery> ();

        MockDataStore dataStore = new MockDataStore();

        public ReturnViewModel()
        {
            Delivery = new ObservableRangeCollection<Delivery>();
            for (int i = 0; i < dataStore.GetDeliveries().Count; i++)
            {
                if (dataStore.GetDeliveries()[i].GetStatus() == Status.Versendet)
                {
                    Delivery.Add(dataStore.GetDeliveries()[i]);
                }
            }
        }
    }
}
