using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public class Adam
    {
        static Adam adam;
        private Adam() { }
        public static Adam GetInstance()
        {
            if (adam == null)
                adam = new Adam();
            return adam;
        }
    }
}
