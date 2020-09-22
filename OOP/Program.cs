using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo phanSo1 = new PhanSo();
            PhanSo phanSo2 = new PhanSo();
            phanSo1.Input();
            phanSo2.Input();
            PhanSo res = phanSo1.CongPs(phanSo2);
            PhanSo res1 = phanSo1.TruPs(phanSo2);
            PhanSo res2 = phanSo1.NhanPs(phanSo2);
            PhanSo res3 = phanSo1.ChiaPs(phanSo2);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Tinh toan phan so");
            Console.WriteLine("Cong phan so: "+res.Output());
            Console.WriteLine("Tru phan so: " + res1.Output());
            Console.WriteLine("Nhan phan so: " + res2.Output());
            Console.WriteLine("Chia phan so: " + res3.Output());
            Console.ReadKey();
        }
    }
}
