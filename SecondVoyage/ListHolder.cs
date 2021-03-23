using System;
using System.Collections.Generic;
using System.Text;

namespace SecondVoyage
{
    class ListHolder
    {
        private static ListHolder instance;

        private ListHolder() { }

        public static ListHolder GetInstance() 
        {
            if (instance == null)
            {
                instance = new ListHolder();
            }

            return instance;
        }
       
    }
}
