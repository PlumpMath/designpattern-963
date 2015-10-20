using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //first call
            var config1 = Singleton.getInstance();
            config1.SessionName = "AMOS";
            Console.WriteLine("first call," + config1.SessionName);
            //second call
            var config2 = Singleton.getInstance();
            Console.WriteLine("second call," + config2.SessionName);
            Console.ReadKey();
        }
    }
}
