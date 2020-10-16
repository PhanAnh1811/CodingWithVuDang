using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person
            //Person person = new Person("Phan Tuan Anh", "55/31/14 Thanh My");
            //Staff staff = new Staff(person.Name, person.Address, "HUFLIT", 15000000);
            //Student student = new Student(person.Name, person.Address, "CNTT",2000,2500000);
            //Console.WriteLine(person.toString());
            //Console.WriteLine(staff.toString());
            //Console.WriteLine(student.toString());
            #endregion

            #region Shape
            Circle circle = new Circle("red", true, 2);
            Square square = new Square(circle.Color, circle.Filled, 5, 4, 2);
            Rectangle rectangle = new Rectangle(circle.Color, circle.Filled, 3, 6);
            Console.WriteLine(circle.toString());
            Console.WriteLine(rectangle.toString());
            Console.WriteLine(square.toString());
            #endregion
        }
    }
}
