using FactoryMethod.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class IcescreamFoctory
    {
        public static Icescream createIcescream(IcescreamType type)
        {
            switch (type)
            {
                case IcescreamType.Chocolate:
                    {
                        return new Chocolate();
                        break;
                    }
                case IcescreamType.Strawberry:
                    {
                        return new Strawberry();
                        break;
                    }
                case IcescreamType.Vanilla:
                    {
                        return new Vanilla();
                        break;
                    }
                default:
                    {
                        return new Vanilla();
                        break;
                    }

            }
        }
    }
}
