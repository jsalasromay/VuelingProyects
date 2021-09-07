using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public sealed class Adam : Male
    {
        static Adam adam;
        private Adam() : base("Adam", null, null) { }
        public static Adam GetInstance()
        {
            if (adam == null)
                adam = new Adam();
            return adam;
        }
    }
}
