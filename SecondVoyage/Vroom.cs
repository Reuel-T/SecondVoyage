using System;
using System.Collections.Generic;
using System.Text;

namespace SecondVoyage
{
    public class Vroom
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public int Sales { get; set; }

        public Vroom(string make, string model, double price, string color, int qty)
        {
            Make = make;
            Model = model;
            Price = price;
            Color = color;
            Sales = qty;

        }
    }
}
