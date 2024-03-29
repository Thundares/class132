using System;
using System.Text;

namespace class132.Entities
{


    class ImportedProduct : Product
    {
        public double customsFee { get ; set ;}
        
        public ImportedProduct(){}
        public ImportedProduct(string name, double price, double cf) : base(name, price)
        {
            customsFee = cf;
        }
        public sealed override string priceTag()
        {
            StringBuilder ret = new StringBuilder();
            ret.Append(base.Name);
            ret.Append(" $ ");
            ret.Append(base.Price.ToString("F2"));
            ret.Append("(Customs fee: $");
            ret.Append(customsFee.ToString("F2"));
            ret.Append(")");
            return ret.ToString();
        }

    }
}