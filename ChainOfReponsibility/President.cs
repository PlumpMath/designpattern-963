using ChainOfReponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsibility
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount > 100000 && purchase.Amount < 999999)
            {
                Console.WriteLine("President will be approver");
            }
            else
            {
                if (this._successor != null)
                {
                    base._successor.ProcessRequest(purchase);
                }
            }
        }

    }
}
