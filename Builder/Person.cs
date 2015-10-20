using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Person
    {
        public Person(string firstName,string lastName,Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }
        public Int16 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
