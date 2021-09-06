using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    class Table
    {
        public List<Menu> Menus { get; set; }
        public Table(List<Menu> menus)
        {
            Menus = menus;
        }
    }
}
