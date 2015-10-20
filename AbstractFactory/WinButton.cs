using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Interface
{
    public class WinButton : Button
    {
        public override void paint()
        {
            Console.WriteLine("window button");
        }
    }
}
