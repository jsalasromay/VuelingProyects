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
	}
}
