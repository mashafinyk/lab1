using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class Orders : Entity, IAggregateRoot
    {
        public DateTime Date { get; private set; }

        public string Status { get; private set; }

        public decimal Price { get; private set; }

        public int UserId { get; private set; }

        public int? ShopId { get; private set; }

        public User User { get; private set; }

        public Shop Shop { get; private set; }

        private Orders()
        {
        }

        public Orders(DateTime date, string status, decimal price, int userId, int? shopId)
        {
            Date = date;
            Status = status;
            Price = price;
            UserId = userId;
            ShopId = shopId;
        }
    }
}