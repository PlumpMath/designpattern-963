using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Interface
{
    public class WindowFactory : GUIFactory
    {
        public override Button createButton()
        {
            return new WinButton();
        }
    }
}
