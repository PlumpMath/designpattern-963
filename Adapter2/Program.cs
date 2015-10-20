using Adapter2;
using Adapter2.Interfaces;
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
            IUSBAdapter cardReader = new CardReader("sdcard");
            var data = cardReader.Read();
        }
    }
}
