using NullObject.Interfaces;
using NullObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject.Factory
{
    public static class CustomerFactory
    {
        private static string[] customers = { "aa", "bb", "cc" };  
        public static ICustomer getCustomer(string displayName)
        {
            foreach (var c in customers)
            {
                if (c.Equals(displayName))
                {
                    return new Customer(c);
                }
            }
            return new NullCustomer();
        }
    }
}
