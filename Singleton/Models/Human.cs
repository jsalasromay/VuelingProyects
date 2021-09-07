using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public abstract class Human
    {
		public readonly string Name;
		public readonly Female Mother;
		public readonly Male Father;
		public Human(string name, Female mother, Male father)
		{
			Name = name;
			Mother = mother;
			Father = father;
		}
	}
}
