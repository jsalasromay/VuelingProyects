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
            Client client = userService.Register("jesus@email.com", "1234");
            BankAccount bankAccount = bankService.Create(client, "ES36547", 2138.15m);
        }
    }
}
