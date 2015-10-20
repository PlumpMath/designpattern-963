using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : ExpectedInterface
    {
        private IAdaptee adaptee;
        public Adapter(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public Adapter()
        {
            adaptee = new Adaptee();
        }
        public void doWork()
        {
            adaptee.actualDoWork();
        }
    }
}
