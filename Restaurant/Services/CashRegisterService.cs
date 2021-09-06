using Restaurant.Interfaces;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Services
{
    class CashRegisterService : IOperable
    {
        public decimal CalculatePrice(Table table)
        {
            decimal total = 0;
            foreach (var menu in table.Menus)
                total += menu.Price;
            return total;
        }
    }
}
