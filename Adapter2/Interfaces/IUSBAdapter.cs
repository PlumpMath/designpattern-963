using Adapter2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2.Interfaces
{
    public interface IUSBAdapter
    {
        Data Read();
    }
}
