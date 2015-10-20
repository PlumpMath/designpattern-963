using Adapter2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public interface ISDCard
    {
        Data ReadFull();
    }
    public class SDCard : ISDCard
    {
        public Data ReadFull()
        {
            return new Data()
            {
                id = 1,
                Content = "Data from SD card"
            };
        }
    }
}
