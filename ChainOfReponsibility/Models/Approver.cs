using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfReponsibility.Models
{
    public abstract class Approver
    {
        protected Approver _successor;
        public void SetSuccessor(Approver successor)
        {
            this._successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
