using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Phan Tuan Anh", "55/31/14 Thanh My");
            Staff staff = new Staff(person.Name, person.Address, "HUFLIT", 15000000);
            Student student = new Student(person.Name, person.Address, "CNTT",2000,2500000);
            Console.WriteLine(person.toString());
            Console.WriteLine(staff.toString());
            Console.WriteLine(student.toString());
        }
    }
}
