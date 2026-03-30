using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Order : Entity, IAggregateRoot
    {
        public DateTime Date { get; private set; }
        public string Status { get; private set; }
        public decimal Price { get; private set; }
        public string DeliveryType { get; private set; }
        public string PaymentType { get; private set; }

        public int UserId { get; private set; }
        public int ShopId { get; private set; }

        public Order(
            DateTime date,
            string status,
            decimal price,
            string deliveryType,
            string paymentType,
            int userId,
            int shopId)
        {
            Date = date;
            Status = status;
            Price = price;
            DeliveryType = deliveryType;
            PaymentType = paymentType;
            UserId = userId;
            ShopId = shopId;
        }
    }
}
