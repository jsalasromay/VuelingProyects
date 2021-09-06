using BankProyect.Models;
using BankProyect.Services;
using System;

namespace BankProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            BankService bankService = new BankService();
            Client client = userService.Register("jesus@email.com", "1234", "687698678");
            BankAccount bankAccount = bankService.Create(client, "ES36547", 2100.15m);
            Client client2 = userService.Register("raul@email.com", "1234", "678654623");
            BankAccount bankAccount2 = bankService.Create(client2, "ES76347", 3100.15m);
            bankService.SendBalance(340m, bankAccount, bankAccount2);
        }
    }
}
