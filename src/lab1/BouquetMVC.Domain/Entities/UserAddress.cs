using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class UserAddress : Entity
    {
        public string City { get; private set; }

        public string Street { get; private set; }

        public string BuildingNumber { get; private set; }

        public int UserId { get; private set; }

        public User User { get; private set; }

        private UserAddress()
        {
        }

        public UserAddress(
            string city,
            string street,
            string buildingNumber,
            int userId)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
            UserId = userId;
        }
    }
}
