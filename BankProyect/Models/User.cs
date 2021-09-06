using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Models
{
    public abstract class User
    {
        public String Email { get; set; }
        public String Password { get; set; }
        protected User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
