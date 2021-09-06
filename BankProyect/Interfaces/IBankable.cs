using BankProyect.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Interfaces
{
    interface IBankable
    {
        public BankAccount Create(Client client, String iban, decimal Balance);
    }
}
