using Adapter2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    public interface IMicroSDCard {
        Data ReadData();
    }
    public class MicroSDCard : IMicroSDCard
    {
        public MicroSDCard()
        {

        }
        public Data ReadData()
        {
            return new Data() { 
                id=1,
                Content = "Data from Micro SD card"
            };
        }
    }
}
