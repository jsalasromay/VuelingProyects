using Builder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Coffee
	{
		public string Sort { get; set; }
		public List<Milk> Milk { get; set; }
		public List<Sugar> Sugar { get; set; }

		public Coffee(string sort, List<Milk> milk, List<Sugar> sugar)
		{
			Sort = sort;
			Milk = milk;
			Sugar = sugar;
		}
		public override string ToString()
		{
			string milk = string.Join(", ", Milk.Select(e => e.ToString()).ToArray());
			string sugar = string.Join(", ", Sugar.Select(e => e.ToString()).ToArray());
			return $"Coffee: {Sort}. {milk} {sugar}";
		}
		public Coffee() { Milk = new List<Milk>(); Sugar = new List<Sugar>(); }
		public Coffee SetBlackCoffee() { Sort = "Black"; return this; }
		public Coffee SetCubanoCoffee() { Sort = "Cubano"; Sugar.Add(new Sugar("Brown")); return this; }
		public Coffee SetAntoccinoCoffee() { Sort = "Americano"; Milk.Add(new Milk(0.5)); return this; }
		public Coffee WithMilk(double fat) { Milk.Add(new Milk(fat)); return this; }
		public Coffee WithSugar(string sort) { Sugar.Add(new Sugar(sort)); return this; }
		public Coffee Build() { return new Coffee(Sort, Milk, Sugar); }
	}
}
