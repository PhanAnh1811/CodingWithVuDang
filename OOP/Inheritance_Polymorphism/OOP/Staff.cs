using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Staff:Person
    {
        private string school;
        private double pay;

        public string School { get => school; set => school = value; }
        public double Pay { get => pay; set => pay = value; }
        public Staff() { }
        public Staff(string name,string address,string school,double pay)
            :base(name,address)
        {
            Name = name;
            Address = address;
            School = school;
            Pay = pay;
        }
        public override string toString()
        {
            return "Staff[" + base.toString()
                + ", school = " + School
                + ", pay = " + Pay + "]";
        }
    }
}
