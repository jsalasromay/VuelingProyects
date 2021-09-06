using BankProyect.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Interfaces
{
    interface IUserable
    {
        public Client Register(String email, String password, String phone);
    }
}
