using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    public class Sugar
	{
		public readonly string Sort;

		public Sugar(string sort)
		{
			Sort = sort;
		}
		public override string ToString()
		{
			return $"Sugar: {Sort}.";
		}
	}
}
