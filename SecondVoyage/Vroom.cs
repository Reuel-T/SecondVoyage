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

        public Vroom(string make, string model, double price, string color)
        {
            Make = make;
            Model = model;
            Price = price;
            Color = color;
        }
    }
}
