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
            #region Phanso
            //PhanSo phanSo1 = new PhanSo();
            //PhanSo phanSo2 = new PhanSo();
            //phanSo1.Input();
            //phanSo2.Input();
            //PhanSo res = phanSo1.CongPs(phanSo2);
            //PhanSo res1 = phanSo1.TruPs(phanSo2);
            //PhanSo res2 = phanSo1.NhanPs(phanSo2);
            //PhanSo res3 = phanSo1.ChiaPs(phanSo2);
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Tinh toan phan so");
            //Console.WriteLine("Cong phan so: " + res.Output());
            //Console.WriteLine("Tru phan so: " + res1.Output());
            //Console.WriteLine("Nhan phan so: " + res2.Output());
            //Console.WriteLine("Chia phan so: " + res3.Output());
            //Console.ReadKey();
            #endregion

            #region Point 2D
            //Point2D p1 = new Point2D();
            //Point2D p2 = new Point2D();
            //p1.Input();
            //p2.Input();
            //Console.WriteLine("Toa do diem 1: " + p1.ToString());
            //Console.WriteLine("Toa do diem 2: " + p2.ToString());

            //p1.Move(5, 5);
            //Console.WriteLine(p1.ToString());

            //if (p1.isOrigin() == true)
            //    Console.WriteLine("Diem do la goc toa do");
            //else
            //    Console.WriteLine("Diem do khong phai la goc toa do");
            //Console.WriteLine("Khoang cach tu diem 1 den diem 2: "+p1.Distance(p2));
            //Console.WriteLine("Khoang cach giua 2 diem: "+Point2D.Distance(p1, p2));
            #endregion

            #region Triangle
            //Point2D p1 = new Point2D();
            //Point2D p2 = new Point2D();
            //Point2D p3 = new Point2D();
            //p1.Input();
            //Console.WriteLine();
            //p2.Input();
            //Console.WriteLine();
            //p3.Input();
            //Triangle triangle = new Triangle(p1, p2, p3);
            //Console.WriteLine("Toa do diem 1: " + p1.ToString());
            //Console.WriteLine("Toa do diem 2: " + p2.ToString());
            //Console.WriteLine("Toa do diem 3: " + p3.ToString());
            //Console.WriteLine();
            //double d1 = Point2D.Distance(p1, p2);
            //double d2 = Point2D.Distance(p1, p3);
            //double d3 = Point2D.Distance(p2, p3);
            //Console.WriteLine("Khoang cach giua diem 1 va 2: " + d1);
            //Console.WriteLine("Khoang cach giua diem 1 va 3: " + d2);
            //Console.WriteLine("Khoang cach giua diem 2 va 3: " + d3);
            //Console.WriteLine();

            //Console.WriteLine("chu vi cua tam giac: " + triangle.Perimeter(d1, d2, d3));
            //double halfPerimeter = (triangle.Perimeter(d1, d2, d3) * 1.0) / 2;
            //Console.WriteLine("Nua chu vi: " + halfPerimeter);
            //Console.WriteLine("Dien tich tam giac: " + triangle.Area(halfPerimeter, d1, d2, d3));
            #endregion

            #region Rectangle
            //Rectangle rectangle = new Rectangle();
            //rectangle.Input();
            //Console.WriteLine();
            //rectangle.Output();
            //Console.WriteLine();
            //Console.WriteLine("Chu vi hinh chu nhat: " + rectangle.Perimeter());
            //Console.WriteLine("Dien tich hinh chu nhat: " + rectangle.Area());
            //Console.WriteLine("Do dai duong cheo: " + rectangle.Diagonal());
            #endregion

            #region Date
            //Date date = new Date();
            //date.Input();
            //Console.WriteLine();
            //Console.WriteLine(date.ToString());
            #endregion

            #region Author
            Author author = new Author();
            author.Input();
            Console.WriteLine();
            Console.WriteLine(author.ToString());
            Console.WriteLine();
            Book book = new Book();
            book.Input();
            book.Author = author;
            Console.WriteLine();
            Console.WriteLine(book.ToString());
            #endregion
            Console.ReadKey();
        }
    }
}
