using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouquetMVC.Domain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(string name, string email, string phoneNumber, string login, string password)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Login = login;
            Password = password;
        }
    }
}
