using BouquetMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class Shop : Entity
    {
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public string OpeningTime { get; private set; }
        public string ClosingTime { get; private set; }

        public Shop(string address, string phoneNumber, string workingHours)
        {
            Address = address;
            PhoneNumber = phoneNumber;
            OpeningTime = workingHours;
            ClosingTime = ClosingTime;
        }
    }
}
