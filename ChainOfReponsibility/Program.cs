using ChainOfReponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var aa = new Director();
            var bb = new VicePresident();
            var cc = new President();

            aa.SetSuccessor(bb);
            bb.SetSuccessor(cc);

            var purchase = new Purchase(1, 150000, "test");
            aa.ProcessRequest(purchase);
            Console.Read();
        }
    }
}
