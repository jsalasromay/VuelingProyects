using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public class Female : Human
    {
        public Female(string name, Female mother, Male father) : base(name, mother, father)
        {
        }
    }
}
