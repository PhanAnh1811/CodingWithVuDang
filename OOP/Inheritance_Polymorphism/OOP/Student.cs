using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Student:Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }
        public double Fee { get => fee; set => fee = value; }
        public Student() { }
        public Student(string name, string address, string program, int year, double fee)
            : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
            Name = name;
            Address = address;
        }
        public override string toString()
        {
            return "Student[" + base.toString()
                + ", program = " + Program
                + ", year = " + Year
                + ", fee = " + Fee + "]";
        }
    }
}
