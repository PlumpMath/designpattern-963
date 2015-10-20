using NullObject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Models
{
    public class NullCustomer : AbstractCustomer
    {
        public NullCustomer():base("")
        {
        }
        public override string DisplayName
        {
            get
            {
                return "This is nullable customer";
            }
        }
        public override bool IsNil
        {
            get
            {
                return true;
            }
        }
    }
}
