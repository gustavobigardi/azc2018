using Callcenter.Domain.ValueObjects;
using Callcenter.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Domain.Entities
{
    public class User : Entity
    {
        public User(Name name, Document document, Email email, string password)
        {
            Name = name;
            Document = document;
            Email = email;
            Password = password;
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; private set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
