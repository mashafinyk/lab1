using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class BouquetFlower : Entity
    {
        public int FlowerId { get; private set; }
        public int BouquetId { get; private set; }

        public BouquetFlower(int flowerId, int bouquetId)
        {
            FlowerId = flowerId;
            BouquetId = bouquetId;
        }
    }
}
