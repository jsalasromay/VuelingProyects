using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    public class Milk
	{
		public readonly double Fat;

		public Milk(double fat)
		{
			Fat = fat;
		}
		public override string ToString()
		{
			return $"Milk: {Fat}.";
		}
	}
}
