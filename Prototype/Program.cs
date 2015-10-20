using Prototype.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var supermarket = new SuperMarket();
            supermarket.AddProduct("Milk", new Milk(100));
            supermarket.AddProduct("Bread",new Bread(250));

            var currentMilk = supermarket.GetProduct("Milk");
            var currentBread = supermarket.GetProduct("Bread");

            var newMilk = (Milk) currentMilk.Clone();
            newMilk.Price=120;
            var newBread = (Bread) currentBread.Clone();
            newBread.Price = 245;
            Console.WriteLine(string.Format("Milk: new ={0} ,old ={1} ",newMilk.Price,currentMilk.Price));
            Console.WriteLine(string.Format("Bread: new ={0} ,old ={1} ",newBread.Price,currentBread.Price));
            Console.Read();
        }
    }
}
