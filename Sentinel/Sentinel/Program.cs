using System;

namespace Sentinel
{
    class Program
    {
        /*Goi ham bai 3*/
        static bool IsPrime(int x)
        {
            int count = 0;
            for (int i = 1; i < x; i++)
                if (x % i == 0)
                    count++;
            if (count == 2)
                return true;
            else
                return false;
        }

        
        static bool [] Eratosthene(int n)
        {
            bool[] status = new bool[n + 1];
            for (int i = 0; i < status.Length; i++)
                status[i] = true;
            status[0] = status[1] = false;
            for(int i = 2; i * i <= n; i++)
            {
                if (status[i])
                {
                    for (int j = i * i; j <= n; j += i)
                        status[j] = false;
                }
            }
            return status;
        }
        static void Main(string[] args)
        {
            // //Bai 1
            //int total = 0;
            //int count = 0;
            //int score = int.Parse(Console.ReadLine());
            //while (score != -1 && score <= 10) 
            //{
            //    total += score;
            //    count += 1;
            //    score = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine(count);
            //Console.WriteLine("{0:0.00}",total/count);


            // //Bai 2
            //bool flag = false;
            //Console.Write("Nhap n: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int[] a = new int[n];
            //for(int i = 0; i < a.Length; i++)
            //{
            //    Console.Write("Nhap phan tu: ");
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.Write("Mang a: ");
            //for (int i = 0; i < a.Length; i++)
            //    Console.Write(" " + a[i]);
            //Console.WriteLine();
            //Console.Write("Nhap gia tri x: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for (int i = 0; i < a.Length; i++)
            //    if (a[i] == x)
            //        flag = true;
            //if (flag == true)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");


            // //Bai 3
            //int n;
            //bool flag = true;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //if (IsPrime(n) == flag)
            //    Console.WriteLine("No");
            //else
            //    Console.WriteLine("Yes");


            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("a = ");
            for (int i = 0; i < a.Length; i++)
                Console.Write("{0} ", a[i]);

            int[] count = new int[n + 100];
            for (int i = 0; i < count.Length; i++)
                count[i] = 0;
            for (int i = 0; i < a.Length; i++)
                count[a[i]]++;
            Console.WriteLine();
            // //Dem so luong so duong
            //for (int i = 0; i < count.Length; i++)
            //    if (count[i] > 0)
            //        Console.WriteLine("So {0}: xuat hien {1} lan", i, count[i]);

            // //So nho nhat khong xuat hien trong a
            Console.Write("So nho nhat khong co trong mang: ");
            for (int i = 1; i < count.Length; i++)
                if (count[i] == 0)
                {
                    Console.WriteLine(i);
                    break;
                }


            // //Thuat toan Eratosthene (San nguyen to)
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //bool[] status = Eratosthene(n);
            //for (int i = 2; i <= n; i++)
            //{
            //    if (status[i] == true)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    else
            //        Console.Write("");
            //}
            // //Toan tu 3 ngoi
            //for (int i = 2; i <= n; i++)
            //    Console.Write(status[i] ? (i + " ") : "");
        }
    }
}
