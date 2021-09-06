using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Models
{
    public class Client : User
    {
        public String Phone { get; set; }
        public Client(String email, String password, String Phone) : base(email, password) { this.Phone = Phone; }
    }
}
