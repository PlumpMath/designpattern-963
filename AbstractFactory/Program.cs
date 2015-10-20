using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = GUIFactory.getFactory().createButton();
            button.paint();
            Console.Read();
        }
    }
}
