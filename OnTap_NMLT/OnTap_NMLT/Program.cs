using System;

namespace OnTap_NMLT
{
    class Program
    {
        /*Goi ham bai 1*/
        //static double HieuSuat(ref int cold, ref int hot)
        //{
        //    double h;
        //    h = 1 - ((cold * 1.0 + 273) / (hot + 273));
        //    return h;
        //}
        //static void Output(int cold, int hot)
        //{
        //    Console.WriteLine("Hieu suat cua may lanh = " + HieuSuat(ref cold, ref hot));
        //}

        /*Goi ham bai 2*/
        static double XacSuat(int m, int n)
        {
            double s = 1;
            for (int i = 0; i < m; i++)
            {
                s *= (m * 1.0 - i) / (n - i);
            }
            return s;
        }

        /*Goi ham bai 3*/
        //static bool CheckSoThanThiet(int m,int n)
        //{
        //    int SumOfX = 0;
        //    int SumOfY = 0;
        //    for(int i = 1; i < m; i++)
        //        if (m % i == 0)
        //            SumOfX += i;

        //    for (int i = 1; i < n; i++)
        //        if (n % i == 0)
        //            SumOfY += i;
        //    if (SumOfX == n && SumOfY == m)
        //        return true;
        //    return false;
        //}

        /*Goi ham bai 4*/
        static int SearchLastX(int[] A,int x)
        {
            int pos = 0;
            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] == x)
                    pos = i;
            }
            return pos;
        }

        static void Main(string[] args)
        {
            // //Bai 1
            //int cold, hot;
            //Console.Write("Nhap nhiet do nguon lanh: ");
            //cold = int.Parse(Console.ReadLine());
            //Console.Write("Nhap nhiet do nguon nong: ");
            //hot = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------");
            //Output(cold, hot);

            // //Bai 2
            int m, n;
            do
            {
                Console.Write("Nhap m: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Nhap n: ");
                n = int.Parse(Console.ReadLine());
            } while (m > n);
            Console.WriteLine("Xac suat trung so o VN: " + XacSuat(m, n));

            // //Bai 3
            //int m, n;
            //Console.Write("Nhap m: ");
            //m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (CheckSoThanThiet(m, n) == true)
            //    Console.WriteLine("Cap so than thiet");
            //else
            //    Console.WriteLine("Khong phai la cap so than thiet");

            // //Bai 4
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------");
            //int[] A = new int[n];
            //for(int i = 0; i < A.Length; i++)
            //{
            //    Console.Write("Nhap phan tu thu {0}: ", i + 1);
            //    A[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Mang A gom nhung phan tu");
            //for(int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine("A[{0}] = {1}", i, A[i]);
            //}
            //Console.WriteLine("---------------------------------");
            //int v;
            //Console.Write("Nhap gia tri x: ");
            //v = int.Parse(Console.ReadLine());
            //Console.WriteLine("Vi tri xuat hien cuoi cung cua x: " + SearchLastX(A, v));
        }
    }
}
