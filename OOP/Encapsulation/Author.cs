using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Author
    {
        private string name;
        private string email;
        private char gender;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Author() { }
        public Author(string name,string email,char gender)
        {
            Name = name;
            Email = email;
            if (gender == 'm' || gender == 'f')
                Gender = gender;
        }


        public Author(Author author)
        {
            Name = author.Name;
            Email = author.email;
            Gender = author.Gender;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ten tac gia: ");
            name = Console.ReadLine();
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gender = char.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Author[name= " + Name + ", email= " + Email + ", gender= " + Gender + "]";
        }
    }
}
