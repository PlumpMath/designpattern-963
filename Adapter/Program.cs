using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpectedInterface adapter = new Adapter();
            Operation(adapter);
        }
        public static void Operation(ExpectedInterface expected)
        {
            expected.doWork();
        }
    }
}
