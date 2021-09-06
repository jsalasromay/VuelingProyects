using BankProyect.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Services
{
    class EmailService : ISendable
    {
        public string Send(string email, string content)
        {
            if (!ValidateEmail(email))
                throw new Exception("Email is not an email");
            return email + " " + content;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
