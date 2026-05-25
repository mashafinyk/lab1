using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVС.Domain.Entities
{
    public class BouquetAndFlower : Entity
    {
        public int FlowerId { get; private set; }
        public int BouquetId { get; private set; }
        public Bouquet Bouquet { get; private set; }
        public TypeOfFlower Flower { get; private set; }

        public BouquetAndFlower(int flowerId, int bouquetId)
        {
            FlowerId = flowerId;
            BouquetId = bouquetId;
        }
    }
}
