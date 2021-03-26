using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;

namespace SecondVoyage
{
    class ListHolder
    {
        private static ListHolder instance;

        private ListHolder() { }

        private ObservableCollection<Vroom> vrooms = new ObservableCollection<Vroom>();

        public ObservableCollection<Vroom> Vrooms { get => vrooms; }

        public static ListHolder GetInstance() 
        {
            if (instance == null)
            {
                instance = new ListHolder();
            }

            return instance;
        }

        public void AddVroom(Vroom vroom) 
        {
            vrooms.Add(vroom);
        }

        public void RemoveVroom(Vroom vroom) 
        {
            vrooms.Remove(vroom);
        }

        public string Report() 
        {
            string vehicles = String.Empty;
            double totalPrice = 0;
            string heading = "VROOM SALES REPORT\n\n";

            string totalSales = String.Empty;

            string MainFormat = "{0, -25} {1, -25} {2, -25} {3, -25} {4, -25}\n";

            string titles = String.Format(MainFormat, "MAKE", "MODEL", "COLOR", "PRICE", "SALES");

            foreach (Vroom vroom in vrooms) 
            {
                vehicles += String.Format(MainFormat, vroom.Make, vroom.Model, vroom.Color, vroom.Price, vroom.Sales);
                totalPrice += vroom.Sales * vroom.Price;
                totalSales += String.Format("{0, -45} {1}", $"{vroom.Make} {vroom.Model}", $"{vroom.Sales * vroom.Price}");
            }

            string report = $"{heading}{titles}\n{vehicles}\n\nSALES PER VEHICLE\n{totalSales}\n\nSALES TOTAL\n{totalPrice}";

            return report;
        }
       
    }
}
