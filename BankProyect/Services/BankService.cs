using BankProyect.Interfaces;
using BankProyect.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Services
{
    class BankService : IBankable
    {
        public BankAccount Create(Client client, string iban, decimal Balance)
        {
            BankAccount bankAccount = new BankAccount(iban, Balance, client);
            return bankAccount;
        }
    }
}
