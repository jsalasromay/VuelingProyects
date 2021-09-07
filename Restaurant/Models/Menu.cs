using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.Models
{
    public class Menu
    {
        public string Type { get; set; }
        public List<Starter> Starter { get; set; }
        public List<MainCourse> MainCourse { get; set; }
        public List<Dessert> Dessert { get; set; }
        public decimal Price { get; set; }
        public Menu(string type, List<Starter> starter, List<MainCourse> mainCourse, List<Dessert> dessert, decimal price)
        {
            Type = type;
            Starter = starter;
            MainCourse = mainCourse;
            Dessert = dessert;
            Price += price;
        }
        public override string ToString()
        {
            string starter = string.Join(" with ", Starter.Select(e => e.ToString()).ToArray());
            string mainCourse = string.Join(" with ", MainCourse.Select(e => e.ToString()).ToArray());
            string dessert = string.Join(" with ", Dessert.Select(e => e.ToString()).ToArray());
            return $"Menu: {Type}. Starter: {starter}. Main course: {mainCourse}. Dessert: {dessert}.";
        }
        public Menu() { Starter = new List<Starter>(); MainCourse = new List<MainCourse>(); Dessert = new List<Dessert>(); }
        public Menu SetChildrenMenu() { Type = "Children"; Price = 6.5m; return this; }
        public Menu SetCarnivoreMenu() { Type = "Carnivore"; Price = 11.75m; return this; }
        public Menu SetVeganMenu() { Type = "Vegan"; Price = 14.25m; return this; }
        public Menu WithStarter(String ingredient, decimal price) { Starter.Add(new Starter(ingredient)); Price += price; return this; }
        public Menu WithMainCourse(String ingredient, decimal price) { MainCourse.Add(new MainCourse(ingredient)); Price += price; return this; }
        public Menu WithDessert(String ingredient, decimal price) { Dessert.Add(new Dessert(ingredient)); Price += price; return this; }
        public Menu Build() { return new Menu(Type, Starter, MainCourse, Dessert, Price); }
    }
}
