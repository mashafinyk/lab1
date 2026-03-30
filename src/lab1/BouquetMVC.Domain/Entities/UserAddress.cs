using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouquet.Domain.Entities
{
    public class UserAddress : Entity
    {
        public string City { get; private set; }
        public string Street { get; private set; }
        public string Building { get; private set; }
        public string Number { get; private set; }

        public int UserId { get; private set; }

        public UserAddress(string city, string street, string building, string number, int userId)
        {
            City = city;
            Street = street;
            Building = building;
            Number = number;
            UserId = userId;
        }
    }
}
