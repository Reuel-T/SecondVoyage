using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace SecondVoyage
{
    class ListHolder
    {
        private static ListHolder instance;

        private ListHolder() { }

        private List<Vroom> vrooms = new List<Vroom>();

        public static ListHolder GetInstance() 
        {
            if (instance == null)
            {
                instance = new ListHolder();
            }

            return instance;
        }

        public void addVroom(Vroom vroom) 
        {
            vrooms.Add(vroom);
        }

        public void sellVroom(string make, string model) 
        {
            Vroom selected = vrooms.Where(x => x.Make.Equals(make) && x.Model.Equals(model)).FirstOrDefault();
            selected.Sales++;
        }
       
    }
}
