using NullObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Models
{
    public class Customer : AbstractCustomer
    {
        public Customer(string displayName):base(displayName)
        {

        }
        public override bool IsNil
        {
            get
            {
                return false;
            }
        }
    }
}
