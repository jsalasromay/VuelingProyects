using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public class Male : Human
    {
        public Male(string name, Female mother, Male father) : base(name, mother, father)
        {
        }
    }
}
