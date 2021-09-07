using Restaurant.Models;
using Restaurant.Services;
using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegisterService cashService = new CashRegisterService();

            var menu1 = new Menu().SetChildrenMenu().WithStarter("Spaguetti", 0).WithMainCourse("Burger", 0).WithDessert("Custard", 0).Build();
            var menu2 = new Menu().SetCarnivoreMenu().WithStarter("Cannelloni", 0).WithMainCourse("Pork ribs", 0).WithMainCourse("Chips", 1).WithDessert("Cake", 0).WithDessert("Coffee", 0.5m).Build();
            var menu3 = new Menu().SetVeganMenu().WithStarter("Salad", 0).WithMainCourse("Roasted peppers", 0).WithMainCourse("Chips", 1).WithDessert("Watermelon", 0).Build();
            var menu4 = new Menu().SetChildrenMenu().WithStarter("Spaguetti", 0).WithMainCourse("Burger", 0).WithDessert("Custard", 0).Build();

            Table table = new Table(new List<Menu> { menu1, menu2, menu3, menu4 });
            decimal price = cashService.CalculatePrice(table);
            Console.WriteLine(menu1);
            Console.WriteLine(menu2);
            Console.WriteLine(menu3);
            Console.WriteLine(menu4);
            Console.WriteLine($"Your bill is: {price}");
        }
    }
}
