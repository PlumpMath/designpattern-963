using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public abstract class ProductPrototype : ICloneable
    {
        public decimal _price;
        public virtual decimal Price {
            get { return this._price; }
            set { this._price = value; }
        }
        public ProductPrototype(decimal price)
        {
            this._price = price;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
