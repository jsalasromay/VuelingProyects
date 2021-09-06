using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Models
{
    class BankAccount
    {
        public String Iban { get; set; }
        public decimal Balance { get; set; }
        public Client client { get; set; }
        public BankAccount(string iban, decimal balance, Client client)
        {
            Iban = iban;
            Balance = balance;
            this.client = client;
        }
    }
}
