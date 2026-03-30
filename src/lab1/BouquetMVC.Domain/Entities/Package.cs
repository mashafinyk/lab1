using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Package : Entity
    {
        public string Kind { get; private set; }
        public string Colour { get; private set; }
        public decimal Price { get; private set; }

        public Package(string kind, string colour, decimal price)
        {
            Kind = kind;
            Colour = colour;
            Price = price;
        }
    }
}
