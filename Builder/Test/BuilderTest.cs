using Builder.Builder;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Test
{
    class BuilderTest
	{
		public static void Test1()
		{
			var actual = new CoffeeBuilder().SetBlackCoffee().WithSugar("Regular").WithMilk(3.2).Build();
			var expected = new Coffee("Black", new List<Milk> { new Milk(3.2) }, new List<Sugar> { new Sugar("Regular") });
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}

		public static void Test2()
		{
			var actual = new CoffeeBuilder().SetAntoccinoCoffee().Build();
			var expected = new Coffee("Americano", new List<Milk> { new Milk(0.5) }, new List<Sugar>());
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}

		public static void Test3()
		{
			var actual = new CoffeeBuilder().SetCubanoCoffee().Build();
			var expected = new Coffee("Cubano", new List<Milk>(), new List<Sugar> { new Sugar("Brown") });
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}
	}
}
