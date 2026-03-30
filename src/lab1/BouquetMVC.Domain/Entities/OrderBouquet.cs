using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class OrderBouquet : Entity
    {
        public int OrderId { get; private set; }
        public int PackageId { get; private set; }
        public int BouquetId { get; private set; }

        public OrderBouquet(int orderId, int packageId, int bouquetId)
        {
            OrderId = orderId;
            PackageId = packageId;
            BouquetId = bouquetId;
        }
    }
}
