using ChainOfReponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsibility
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount > 1000 && purchase.Amount < 9999)
            {
                Console.WriteLine("Directory will be approver");
            }
            else
            {
                base._successor.ProcessRequest(purchase);
            }
        }
    }
}
