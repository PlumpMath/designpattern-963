using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Interface
{
    public class OSXButton : Button
    {
        public OSXButton()
        {

        }

        public override void paint()
        {
            Console.WriteLine("osx button");
        }
    }
}
