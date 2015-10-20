using AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interface
{
    public abstract class GUIFactory
    {
        private const OperatingSystemType sys = OperatingSystemType.Windows;
        public static GUIFactory getFactory()
        {
            if (sys == OperatingSystemType.Windows)
            {
                return new WindowFactory();
            }
            else
            {
                return new OSXFactory();
            }
        }
        public abstract Button createButton();
    }
}
