using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class Strawberry : Icescream
    {
        public override string getFlavor()
        {
            return "Strawberry";
        }
    }
}
