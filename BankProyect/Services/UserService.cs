using BankProyect.Interfaces;
using BankProyect.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Services
{
    class UserService : IUserable
    {
        public Client Register(string email, string password, String phone)
        {
            EmailService emailService = new EmailService();
            Client client = null;
            if (emailService.ValidateEmail(email))
                client = new Client(email, password, phone);
            Console.WriteLine(emailService.Send(email, $"Usuario registrado, user: {email}, contraseña: {password}"));
            return client;
        }
    }
}
