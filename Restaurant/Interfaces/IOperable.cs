using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Interfaces
{
    interface IOperable
    {
        public decimal CalculatePrice(Table table);
    }
}
