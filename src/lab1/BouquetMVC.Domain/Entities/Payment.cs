using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class Payment : Entity
    {
        public DateTime Date { get; private set; }

        public string Type { get; private set; }

        public string Status { get; private set; }

        public string Amount { get; private set; }

        public int OrderId { get; private set; }

        public Orders Order { get; private set; }

        private Payment()
        {
        }

        public Payment(DateTime date, string type, string status, string amount, int orderId)
        {
            Date = date;
            Type = type;
            Status = status;
            Amount = amount;
            OrderId = orderId;
        }
    }
}