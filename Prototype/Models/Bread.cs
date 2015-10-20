using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Bread : ProductPrototype
    {
        private const decimal vat = 7;
        public Bread(decimal price)
            : base(price) { }
        public override decimal Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                base.Price = value + (value * vat) / 100;
            }
        }
    }
}
