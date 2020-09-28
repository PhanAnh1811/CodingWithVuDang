using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Date
    {
        private int day;
        private int month;
        private int year;
        
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Date() { }
        public Date(int day,int month,int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public void Input()
        {
            Console.Write("Nhap ngay: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "" + Day + "/" + Month + "/" + Year;
        }
    }
}
