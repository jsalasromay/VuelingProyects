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

        public void SendBalance(decimal balance, BankAccount destinationBankAccount, BankAccount bankAccount)
        {
            SmsService smsService = new SmsService();
            bankAccount.Balance -= balance;
            destinationBankAccount.Balance += balance;
            Console.WriteLine(smsService.Send(bankAccount.client.Phone, $"Envio de saldo con exito, su nuevo saldo es {bankAccount.Balance}"));
            Console.WriteLine(smsService.Send(destinationBankAccount.client.Phone, $"Envio de saldo con exito, su nuevo saldo es {destinationBankAccount.Balance}"));
        }
    }
}
