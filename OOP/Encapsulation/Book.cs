using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Book:Author
    {
        private string name;
        private Author author;
        private double price;
        private int qty ;


        public Author Author
        {
            get { return author; }
            set { author = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public Book() { }
        public Book(string name,Author author,double price,int qty)
        {
            Name = name;
            Author = author;
            Price = price;
            Qty = qty;
        }
        public override void Input()
        {
            Console.Write("Nhap ten sach: ");
            name = Console.ReadLine();
            Console.Write("Nhap gia tien: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Nhap qty: ");
            qty = int.Parse(Console.ReadLine());
        }
        
        public override string ToString()
        {
            return "Book[name=" + Name +", "+ Author.ToString() + ", price=" + Price + ", qty=" + qty.ToString();
        }
    }
}
