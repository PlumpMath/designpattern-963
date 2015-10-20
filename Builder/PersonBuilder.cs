using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{

    public class PersonBuilder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private Address Address { get; set; }
        public PersonBuilder()
        {
        }
        public PersonBuilder WithFirstName(string firstName)
        {
            this.FirstName = firstName;
            return this;
        }
        public PersonBuilder WithLastName(string lastName)
        {
            this.LastName = lastName;
            return this;
        }
        public PersonBuilder WithAddress(Address address)
        {
            this.Address = address;
            return this;
        }
        public Person Build()
        {
            return new Person(this.FirstName, this.LastName, this.Address);
        }
    }
}
