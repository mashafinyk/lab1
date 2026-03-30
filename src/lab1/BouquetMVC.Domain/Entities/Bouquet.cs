using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Bouquet : Entity, IAggregateRoot
    {
        public decimal Price { get; private set; }
        public double Height { get; private set; }
        public string Kind { get; private set; }

        public int? PromotionId { get; private set; }

        public Bouquet(decimal price, double height, string kind, int? promotionId = null)
        {
            Price = price;
            Height = height;
            Kind = kind;
            PromotionId = promotionId;
        }
    }
}
