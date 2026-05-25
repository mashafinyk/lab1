using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class Bouquet : Entity, IAggregateRoot
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int? PromotionId { get; private set; }

        public Promotion Promotion { get; private set; }

        private Bouquet()
        {
        }

        public Bouquet(
            string name,
            string description,
            decimal price,
            int? promotionId)
        {
            Name = name;
            Description = description;
            Price = price;
            PromotionId = promotionId;
        }
    }
}