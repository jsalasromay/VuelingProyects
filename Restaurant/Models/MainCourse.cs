using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
    public class MainCourse
    {
		private readonly String Ingredient;
		public MainCourse(String ingredient)
		{
			Ingredient = ingredient;
		}
		public override string ToString()
		{
			return $"{Ingredient}";
		}
	}
}
