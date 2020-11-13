using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 4
            //double sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.Write(" " + i);
            //    sum +=1.0/i;
            //}
            //Console.WriteLine();
            //Console.WriteLine("S=" + sum);

            //Bài 5
            //double sum = 1;
            //int j = 1;
            //for(int i = 3; i <= 39; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        double top = i * 1.0;
            //        double bot = Math.Pow(2, j);
            //        j++;
            //        sum += top / bot;
            //    }         
            //}
            //Console.WriteLine("S=" + sum);
            //Bài 6
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for(int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //        Console.Write(" " + i);
            //}
            //Console.Write(" La uoc so chung cua {0}", n);

            //Bài 7
            //int n;
            //int sum = 0;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //for (int i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //        sum += i;
            //}
            //Console.WriteLine("Tong cua uoc so la = " + sum);
            //if (sum == n)
            //{
            //    Console.WriteLine("So hoan hao");
            //}
            //else
            //{
            //    Console.WriteLine("Khong phai so hoan hao");
            //}

            ////BT NMLT
            //Bài 10
            int voChai;
            int n;
            int biaDoiDuoc = 0;
            int voChaiDu = 0;
            int res = 0;
            
            Console.Write("Nhap so chai bia cua anh Bo: ");
            voChai = int.Parse(Console.ReadLine());
            n = voChai;
            while (voChai < 1 || voChai > 1000)
            {
                Console.Write("Nhap lai so chai bia: ");
                voChai = int.Parse(Console.ReadLine());
            }
            while (voChai >= 10)
            {
                biaDoiDuoc = (voChai / 10) * 3;  //(24/10)*3=2*3=6
                voChaiDu = voChai % 10;  //24%10=4
                res += biaDoiDuoc; //res=6
                voChai = voChaiDu + biaDoiDuoc; //vochai=6+4=10
            }
            Console.WriteLine("n={0}->m={1}",n,res+n);
            Console.ReadKey();
        }
    }
}
