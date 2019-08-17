using System;
using System.Text;

namespace class132.Entities
{


    class UsedProduct : Product
    {
        public DateTime manufactureDate { get ; set ;}
        
        public sealed override string priceTag()
        {
            StringBuilder ret = new StringBuilder();
            ret.Append(base.Name);
            ret.Append(" (used) $ ");
            ret.Append(base.Price.ToString("F2"));
            ret.Append("(Manufacture date: ");
            ret.Append(manufactureDate.ToString());
            ret.Append(")");
            return ret.ToString();
        }

    }
}