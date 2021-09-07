using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public sealed class Eve : Female
    {
        Adam _adam;
        static Eve eve;
        private Eve(Adam adam) : base("Eve", null, null) 
        {
            if (adam == null) 
                throw new ArgumentNullException("Eva needs Adam");
            adam = _adam; 
        }
        public static Eve GetInstance(Adam adam)
        {
            if (eve == null)
                eve = new Eve(adam);
            return eve;
        }
    }
}
