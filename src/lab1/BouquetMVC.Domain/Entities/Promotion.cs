using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class Promotion : Entity
    {
        public string Name { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public int DiscountPercent { get; private set; }

        private Promotion()
        {
        }

        public Promotion(string name, DateTime startDate, DateTime endDate, int discountPercent)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            DiscountPercent = discountPercent;
        }
    }
}
