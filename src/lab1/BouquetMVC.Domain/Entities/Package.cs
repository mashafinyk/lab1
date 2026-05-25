using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class Package : Entity
    {
        public string Material { get; private set; }

        public string Color { get; private set; }

        public decimal Price { get; private set; }

        private Package()
        {
        }

        public Package(string material, string color, decimal price)
        {
            Material = material;
            Color = color;
            Price = price;
        }
    }
}
