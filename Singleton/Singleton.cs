using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Configurations configuration;
        public Singleton()
        {

        }
        public static Configurations getInstance(){
            if(configuration == null){
                configuration = new Configurations();
            }
            return configuration;
        }
    }
}
