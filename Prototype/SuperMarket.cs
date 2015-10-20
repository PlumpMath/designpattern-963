using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface ISuperMarket
    {
        void AddProduct(string key, ProductPrototype product);
        ProductPrototype GetProduct(string productName);
    }
    public class SuperMarket : ISuperMarket
    {
        private Dictionary<string, ProductPrototype> products;
        public SuperMarket()
        {
            this.products = new Dictionary<string, ProductPrototype>();
        }
        public void AddProduct(string key, ProductPrototype product)
        {
            this.products.Add(key, product);
        }

        public ProductPrototype GetProduct(string key)
        {
            return (ProductPrototype)this.products[key];
        }
    }
}
