using BankProyect.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Services
{
    class SmsService : ISendable
    {
        public string Send(string phone, string content)
        {
            return phone + " " + content;
        }
    }
}
