using System;

namespace Ham
{
    class Program
    {
        ////Goi ham bai 1
        //static int TinhTong(int a,int b)
        //{
        //    return a + b;
        //}
        //static int TinhHieu(int a,int b)
        //{
        //    return a - b;
        //}
        //static int TinhTich(int a,int b)
        //{
        //    return a * b;
        //}
        //static double TinhThuong(double a, double b)
        //{
        //    return a / b;
        //}

        ////Goi ham bai 2
        //static string Chuoi()
        //{
        //    string s;
        //    Console.Write("Nhap ten chuoi bat ky: ");
        //    s = Console.ReadLine();
        //    return s;
        //}

        ////Goi ham bai 3
        //static int TimSoLonNhat(int a,int b,int c)
        //{
        //    if (a > b && a > c)
        //    {
        //        return a;
        //    }
        //    if (b > a && b > c)
        //    {
        //        return b;
        //    }
        //    return c;
        //}

        ////Goi ham bai 4
        //static int Sum(int n,int sum)
        //{
        //    for(int i = 1; i <= n; i++)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}

        ////Goi ham bai 5
        //static bool Check(int year)
        //{
        //    return ((year / 4 == 0 || year / 100 != 0) || year / 400 == 0);
        //}
        //static int MonthYear(int month, int year)
        //{
        //    switch (month)
        //    {
        //        case 1:
        //        case 3:
        //        case 5:
        //        case 7:
        //        case 8:
        //        case 10:
        //        case 12:
        //            return 31;
        //        case 4:
        //        case 6:
        //        case 9:
        //        case 11:
        //            return 30;
        //        case 2:
        //            if (Check(year))
        //            {
        //                return 29;
        //            }
        //            else
        //            {
        //                return 28;
        //            }
        //        default:
        //            Console.Write("So thang nam nhap khong hop le");
        //            return 0;
        //    }
        //}

        ////Goi ham bai 6
        //static int SumOfDigits(int n)
        //{
        //    int sum = 0;
        //    // 5312
        //    while (n != 0)// khi nao n khac 0 van lam
        //    {
        //        sum += n % 10;
        //        n /= 10;
        //    }
        //    return sum;
        //}

        ////Goi ham bai 7
        //static int MaxOfDigits(int n)
        //{
        //    int max = 0;
        //    while (n != 0)
        //    {
        //        //1349
        //        int temp = n % 10; //1349%10=9
        //        n /= 10; //1349/10=134 
        //        if (temp > max)
        //        {
        //            max = temp;
        //        }
        //    }
        //    return max;
        //}

        ////Goi ham bai 8
        //static int SumOfDivisor(int n)
        //{
        //    int sum = 0;
        //    for(int i = 1; i <= n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            sum += i;
        //        }
        //    }
        //    return sum;
        //}

        ////Goi ham bai 9
        //static void HoanVi(ref int a, ref int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}

        ////Goi ham bai 10
        //static void TangDonVi(ref int a,ref int b)
        //{
        //    a += 10;
        //    b += 10;
        //}

        ////Goi ham bai 11
        static void CapSoCong(ref int a,ref int b,ref int c)
        {
            if ((c - b) != (b - a))
            {
                Console.WriteLine("Khong phai la cap so cong");
            }
            else
            {
                Console.WriteLine("La cap so cong thi tang gap doi don vi");
                Console.WriteLine("a={0},b={1},c={2}", a * 2, b * 2, c * 2);
            }
        }
        static void Main(string[] args)
        {
            ////Bai 1
            //int a, b;
            //Console.Write("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int tong = TinhTong(a, b);
            //int hieu = TinhHieu(a, b);
            //int tich = TinhTich(a, b);
            //double thuong = TinhThuong(a, b);
            //Console.WriteLine("Tong 2 so a va b =" + tong);
            //Console.WriteLine("Hieu 2 so a va b =" + hieu);
            //Console.WriteLine("Tich 2 so a va b =" + tich);
            //Console.WriteLine("Thuong 2 so a va b = {0:0.0}",thuong);

            ////Bai 2
            //string Ten = Chuoi();
            //Console.WriteLine("Chuoi vua nhap tu ban phim: " + Ten);

            ////Bai 3
            //int a, b, c;
            //Console.Write("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("Nhap c: ");
            //c = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int res = TimSoLonNhat(a, b, c);
            //Console.WriteLine("So lon nhat trong 3 so la: " + res);

            ////Bai 4
            //int n;
            //int sum = 0;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int res = Sum(n, sum);
            //Console.WriteLine("Tong cac so tu 1 den n la " + res);

            ////Bai 5
            //int outPut;
            //int month, year;
            //Console.Write("Nhap thang: ");
            //month = int.Parse(Console.ReadLine());
            //Console.Write("Nhap nam: ");
            //year = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //while (year < 0 || month < 1 && month > 12)
            //{
            //    Console.Write("Nhap lai thang: ");
            //    month = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap lai nam: ");
            //    year = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //}

            //outPut = MonthYear(month, year);
            //Console.WriteLine("So ngay trong thang va nam vua nhap la " + outPut);

            ////Bai 6
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //int outPut = SumOfDigits(n);
            //Console.WriteLine("Tong cac chu so cua n la " + outPut);

            ////Bai 7
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());

            //int outPut = MaxOfDigits(n);
            //Console.WriteLine("So lon nhat trong cac chu so la: " + outPut);

            ////Bai 8
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //int outPut = SumOfDivisor(n);
            //Console.WriteLine("So luong cac uoc so: " + outPut);

            //Bai 9
            //int a, b;
            //Console.Write("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = int.Parse(Console.ReadLine());
            //HoanVi(ref a, ref b);
            //Console.WriteLine("Sau khi hoan vi: a={0},b={1}",a,b);

            //Bai 10
            //int a, b;
            //Console.Write("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //TangDonVi(ref a, ref b);
            //Console.WriteLine("Sau khi tang 10 don vi: a={0},b={1}", a, b);

            //Bai 11
            int a, b, c;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = int.Parse(Console.ReadLine());
            CapSoCong(ref a, ref b, ref c);
            Console.ReadKey();
        }
    }
}
