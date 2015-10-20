using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IAdaptee {
        void actualDoWork();
    }
    public class Adaptee : IAdaptee
    {
        public void actualDoWork() {
            Console.WriteLine("actualDoWork");
        }
    }
}
