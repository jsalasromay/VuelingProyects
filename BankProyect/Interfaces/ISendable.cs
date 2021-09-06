using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Interfaces
{
    interface ISendable
    {
        public String Send(String type, String content);
    }
}
