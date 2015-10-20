using ChainOfReponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsibility
{
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount > 10000 && purchase.Amount < 99999)
            {
                Console.WriteLine("VicePresident will be approver");
            }
            else
            {
                base._successor.ProcessRequest(purchase);
            }
        }
    }
}
