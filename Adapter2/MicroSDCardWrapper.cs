using Adapter2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public class MicroSDCardWrapper : IUSBAdapter
    {
        public Models.Data Read()
        {
            return new MicroSDCard().ReadData();
        }
    }
    public class SDCardWrapper : IUSBAdapter
    {
        public Models.Data Read()
        {
            return new SDCard().ReadFull();
        }
    }

}
