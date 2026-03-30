using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Payment : Entity
    {
        public string PaymentType { get; private set; }
        public string Status { get; private set; }
        public decimal Amount { get; private set; }

        public int OrderId { get; private set; }

        public Payment(string paymentType, string status, decimal amount, int orderId)
        {
            PaymentType = paymentType;
            Status = status;
            Amount = amount;
            OrderId = orderId;
        }
    }
}
