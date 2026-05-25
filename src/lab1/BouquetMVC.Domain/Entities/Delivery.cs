using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class Delivery : Entity
    {
        public DateTime Date { get; private set; }

        public string Type { get; private set; }

        public string Status { get; private set; }

        public int ShopId { get; private set; }

        public Shop Shop { get; private set; }

        private Delivery()
        {
        }

        public Delivery(DateTime date, string type, string status, int shopId)
        {
            Date = date;
            Type = type;
            Status = status;
            ShopId = shopId;
        }
    }
}