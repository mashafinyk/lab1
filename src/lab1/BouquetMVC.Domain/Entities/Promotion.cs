using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Promotion : Entity
    {
        public string Name { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public decimal Discount { get; private set; }

        public Promotion(string name, DateTime startDate, DateTime endDate, decimal discount)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Discount = discount;
        }
    }
}
