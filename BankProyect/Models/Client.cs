﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankProyect.Models
{
    public class Client : User
    {
        public Client(String email, String password) : base(email, password) { }
    }
}
