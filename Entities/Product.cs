using System.Text;

namespace class132.Entities
{

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){}

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string priceTag()
        {
            
            StringBuilder ret = new StringBuilder();
            ret.Append(Name);
            ret.Append(" $ ");
            ret.Append(Price.ToString("F2"));
            return ret.ToString();
        }
    }
}