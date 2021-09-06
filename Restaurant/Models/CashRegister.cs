using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class CashRegister
    {
        private static CashRegister _CashRegister;
        private CashRegister() { }
        public static CashRegister GetInstance()
        {
            if (_CashRegister == null)
            {
                _CashRegister = new CashRegister();
            }
            return _CashRegister;
        }
    }
}
