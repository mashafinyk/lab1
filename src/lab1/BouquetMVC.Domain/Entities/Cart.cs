using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class Cart : Entity
    {
        public DateTime CreationDate { get; private set; }
        public string Status { get; private set; }

        public int UserId { get; private set; }

        public Cart(DateTime creationDate, string status, int userId)
        {
            CreationDate = creationDate;
            Status = status;
            UserId = userId;
        }
    }
}
