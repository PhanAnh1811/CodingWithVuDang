using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person
    {
        private string name;
        private string address;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public Person() { }
        public Person(string name,string address)
        {
            Name = name;
            Address = address;
        }
        public virtual string toString()
        {
            return "Person[name = " + Name 
                + ", address = " + address + "]";
        }
    }
}
