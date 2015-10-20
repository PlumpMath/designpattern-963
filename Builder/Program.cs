using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                            .WithFirstName("chansak")
                            .WithLastName("kochasen")
                            .Build();
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.ReadKey();
        }
    }
}
