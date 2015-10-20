using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Milk : ProductPrototype
    {
        public Milk(decimal price)
            : base(price) { }
    }
}
