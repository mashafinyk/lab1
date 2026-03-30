using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Delivery : Entity
    {
        public string Status { get; private set; }
        public DateTime Date { get; private set; }

        public int ShopId { get; private set; }

        public Delivery(string status, DateTime date, int shopId)
        {
            Status = status;
            Date = date;
            ShopId = shopId;
        }
    }
}
