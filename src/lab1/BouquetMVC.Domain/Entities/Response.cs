using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Response : Entity
    {
        public int Rating { get; private set; }
        public string Comment { get; private set; }
        public DateTime Date { get; private set; }

        public int OrderId { get; private set; }

        public Response(int rating, string comment, DateTime date, int orderId)
        {
            Rating = rating;
            Comment = comment;
            Date = date;
            OrderId = orderId;
        }
    }
}
