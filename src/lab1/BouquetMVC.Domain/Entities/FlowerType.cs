using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class FlowerType : Entity
    {
        public string Name { get; private set; }
        public string Colour { get; private set; }
        public double Height { get; private set; }
        public decimal Price { get; private set; }

        public FlowerType(string name, string colour, double height, decimal price)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Price = price;
        }
    }
}
