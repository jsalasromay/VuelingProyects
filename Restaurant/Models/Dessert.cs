using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    public class Dessert
    {
		private readonly String Ingredient;
		public Dessert(String ingredient)
		{
			Ingredient = ingredient;
		}
		public override string ToString()
		{
			return $"Dessert: {Ingredient}";
		}
	}
}
