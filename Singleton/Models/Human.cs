using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public abstract class Human
    {
		public string Name;
		public Female Mother;
		public Male Father;
		public Human(string name, Female mother, Male father)
		{
			Name = name;
			Mother = mother;
			Father = father;
		}
	}
}
