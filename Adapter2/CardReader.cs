using Adapter2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    /// <summary>
    /// Adapter class
    /// </summary>
    public class CardReader : IUSBAdapter
    {
        IUSBAdapter adapter;
        public CardReader(string memorytype)
        {
            var type = memorytype.ToLower();
            if (type == "microsdcard")
            {
                adapter = new MicroSDCardWrapper();
            }
            else if (type == "sdcard")
            {
                adapter = new SDCardWrapper();
            }
        }
        public Models.Data Read()
        {
            return adapter.Read();
        }
    }
}
