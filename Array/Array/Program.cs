using System;

namespace ArrayExample
{
    class Program
    {
        // //Goi ham bai 1
        //static void Array1(int[]A,int n)
        //{
        //    for(int i = 0; i < A.Length; i++)
        //    {
        //        Console.Write("Nhap phan tu thu {0}: ", i + 1);
        //        A[i] = int.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine("-----------------------");
        //    Console.WriteLine("Mang A");
        //    for (int i = 0; i < A.Length; i++) 
        //    {
        //        Console.WriteLine("A[{0}] = {1}", i, A[i]);
        //    }
        //}

        // //Goi ham bai 2
        //static void Array2(double[] A)
        //{
        //    Console.WriteLine("Chieu dai cua mang = " + A.Length);
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        Console.WriteLine("Gia tri phan tu: A[{0}] = {1}", i, A[i]);
        //    }
        //}

        // //Bai toan cua mang
        // //Goi ham tim kiem phan tu
        //static int Search(int[] A, int x)
        //{
        //    Console.Write("Nhap gia tri x: ");
        //    x = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (x == A[i])
        //            return i + 1;
        //    }
        //    return -1;
        //}
        static void Main(string[] args)
        {
            // //Bai 1
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //int[] A = new int[n];
            //for(int i = 0; i < A.Length; i++)
            //{
            //    Console.Write("Nhap phan thu {0}: ", i + 1);
            //    A[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Mang A gom nhung phan tu");
            //for(int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine("A[{0}] = {1} ", i, A[i]);
            //}

            // //Bai 2
            //double[] A = new double[] { 2.5, 2.8, 3.0, 4.1, 4.2, 4.5 };
            //Console.WriteLine("Chieu dai cua mang = " + A.Length);
            //for(int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine("Gia tri phan tu: A[{0}] = {1}", i, A[i]);
            //}

            // //Goi ham bai 1
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //int[] A = new int[n];
            //Array1(A, n);

            // //Goi ham bai 2
            //double[] A = new double[] { 2.2, 2.5, 3.1, 3.5, 4.2, 8.5 };
            //Array2(A);

            // //Bai toan cua Mang
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Nhap phan thu {0}: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Mang A gom nhung phan tu");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("A[{0}] = {1} ", i, A[i]);
            }
            // //Tinh tong gia tri cua mang
            //int sum = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    sum += A[i];
            //}
            //Console.WriteLine("Tong gia tri cua mang = " + sum);

            // //Tim kiem phan tu
            //int x = 0;
            //int res = Search(A, x);
            //Console.WriteLine("Gia tri x nam o vi tri: " + res);

            // //Tim gia tri nho nhat va lon nhat
            //int min = A[0];
            //int max = A[0];
            //for(int i = 0; i < A.Length; i++)
            //{
            //    if (min > A[i])
            //        min = A[i];
            //}
            //for(int i = 0; i < A.Length; i++)
            //{
            //    if (max < A[i])
            //        max = A[i];
            //}
            //Console.WriteLine("Gia tri nho nhat cua mang la: " + min);
            //Console.WriteLine("Gia tri nho nhat cua mang la: " + max);

            // //Sap xep mang tang dan 
            //for (int i = 0; i < A.Length; i++)
            //{
            //    for (int j = i + 1; j < A.Length; j++)
            //    {
            //        if (A[i] > A[j])
            //        {
            //            int temp = A[i];
            //            A[i] = A[j];
            //            A[j] = temp;
            //        }
            //    }
            //}
            //Console.Write("Mang sap xep tang dan: ");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(" " + A[i]);
            //}

            // //Sap xep mang giam dan
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            Console.Write("Mang sap xep giam dan: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(" " + A[i]);
            }

            Console.ReadKey();
        }
    }
}
