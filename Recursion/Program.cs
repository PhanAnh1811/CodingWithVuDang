using System;

namespace Recursion
{
    class Program
    {
        //Bai 1
        static int TinhF(int n)
        {
            if (n == 0)
                return 1;
            return TinhF(n - 1) + (1 / TinhF(n - 1));
        }
        //Bai 2
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        //Bai 3
        static int USCLN(int a,int b)
        {
            if (b == 0)
                return a;
            return USCLN(b, a % b);
        }
        //Bai 4
        static int Combine(int n,int k)
        {
            if (k == 0 || k == n)
                return 1;
            return Combine(n - 1, k) + Combine(n - 1, k - 1);
        }
        //Bai 5
        static double Power(double a,int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 0)
                return (double) Power(a, n / 2) * Power(a, n / 2);

            return (double) a* (Power(a, (n - 1) / 2) * Power(a, (n - 1) / 2));
        }
        //Bai 6
        static void TowerOfHaNoi(int n, char a, char b, char c)
        {
            if (n > 0)
            {
                TowerOfHaNoi(n - 1, a, c, b);
                Console.WriteLine("Chuyen dia tu cot " + a + " sang cot " + c);
                TowerOfHaNoi(n - 1, b, a, c);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            // //Bai 1
            //Console.WriteLine(TinhF(n));

            // //Bai 2
            //Console.WriteLine(Fibonacci(n));

            // //Bai 3
            //int a, b;
            //Console.Write("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine(USCLN(a, b));

            // //Bai 4
            //int k;
            //Console.Write("Nhap k: ");
            //k = int.Parse(Console.ReadLine());
            //Console.WriteLine(Combine(n, k));

            // //Bai 5
            //double a;
            //Console.Write("Nhap a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine(Power(a, n));

            // //Bai 6
            char a = 'A', b = 'B', c = 'C';
            TowerOfHaNoi(n, a, b, c);
        }
    }
}
