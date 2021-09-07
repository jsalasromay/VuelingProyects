using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    public class Starter
    {
        private readonly String Ingredient;
		public Starter(String ingredient)
		{
			Ingredient = ingredient;
		}
		public override string ToString()
		{
			return $"{Ingredient}";
		}
	}
}
