using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class OrderBouquet
    {
        public int OrderId { get; private set; }

        public int BouquetId { get; private set; }

        public int PackageId { get; private set; }

        public int Quantity { get; private set; }

        public Orders Order { get; private set; }

        public Bouquet Bouquet { get; private set; }

        public Package Package { get; private set; }

        private OrderBouquet()
        {
        }

        public OrderBouquet(
            int orderId,
            int bouquetId,
            int packageId,
            int quantity)
        {
            OrderId = orderId;
            BouquetId = bouquetId;
            PackageId = packageId;
            Quantity = quantity;
        }
    }
}
