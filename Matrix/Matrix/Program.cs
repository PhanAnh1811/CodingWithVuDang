using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Bai 1
            //int m, n;
            //Console.Write("Nhap so dong: ");
            //m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------");

            //int[,] a = new int[m, n];
            //for (int i = 0; i < m; i++)
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("Nhap phan tu mang: ");
            //        a[i, j] = int.Parse(Console.ReadLine());

            //    }
            //Console.WriteLine("---------------------------");

            //for (int i = 0; i < m; i++)
            //{
            //    Console.Write("Row " + i + ": ");
            //    for (int j = 0; j < n; j++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for(int j = 0; j < n; j++)
            //{
            //    Console.Write("Col " + j + ": ");
            //    for (int i = 0; i < m; i++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}


            // //Bai 2
            //int m, n;
            //Console.Write("Nhap so dong: ");
            //m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------");

            //int[,] a = new int[m, n];
            //for (int i = 0; i < m; i++)
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("Nhap phan tu mang: ");
            //        a[i, j] = int.Parse(Console.ReadLine());

            //    }
            //Console.WriteLine("---------------------------");

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}


            // //Bai 3
            //int m, n, l;
            //Console.Write("Nhap so dong: ");
            //m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot: ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("Nhap mang 1 chieu: ");
            //l = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------------------");

            //int[,] a = new int[m, n];
            //for (int i = 0; i < m; i++)
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("Nhap phan tu mang 2 chieu: ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //Console.WriteLine("----------------------------------------");

            //int[] price = new int[l];
            //for(int i = 0; i < price.Length; i++)
            //{
            //    Console.Write("Nhap phan tu mang 1 chieu: ");
            //    price[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("-----------------------------------------");
            //for (int i = 0; i < price.Length; i++)
            //    Console.Write(" " + price[i]);
            //Console.WriteLine();
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}
            //int[] sumEveryDay = new int[n];
            //for (int j = 0; j < n; j++)
            //    for (int i = 0; i < m; i++)
            //        sumEveryDay[j] += price[i] * a[i, j];
            //Console.WriteLine("-----------------------------------------");
            //for (int i = 0; i < n; i++)
            //    Console.Write(" " + sumEveryDay[i]);


            // //Bai 4
            //int row, col;
            //Console.Write("Nhap so dong: ");
            //row = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot: ");
            //col = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------------------");

            //int[,] a = new int[row, col];
            //int[,] b = new int[row, col];
            //int[,] c = new int[row, col];

            //for (int i = 0; i < row; i++)
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write("Nhap phan tu cua mang a theo dong: ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //Console.WriteLine("------------------------------------------");

            //for (int i = 0; i < row; i++)
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write("Nhap phan tu cua mang b theo dong: ");
            //        b[i, j] = int.Parse(Console.ReadLine());
            //    }
            //Console.WriteLine("------------------------------------------");

            //Console.WriteLine("Mang A");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("------------------------------------------");

            //Console.WriteLine("Mang B");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //        Console.Write(" " + b[i, j]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("------------------------------------------");

            //Console.WriteLine("CONG MA TRAN");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        c[i, j] += a[i, j] + b[i, j];
            //        Console.Write(" " + c[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            // //Bai 5
            //int row, col, temp;
            //row = int.Parse(Console.ReadLine());
            //col = int.Parse(Console.ReadLine());
            //temp = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------------------");
            //int[,] a = new int[row, col];
            //int[,] b = new int[col, temp];

            //for (int i = 0; i < row; i++)
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write("Nhap phan tu mang a: ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //Console.WriteLine("---------------------------------------------");
            //for (int i = 0; i < col; i++)
            //    for (int j = 0; j < temp; j++)
            //    {
            //        Console.Write("Nhap phan tu mang b: ");
            //        b[i, j] = int.Parse(Console.ReadLine());
            //    }
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Mang a");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Mang b");
            //for (int i = 0; i < col; i++)
            //{
            //    for (int j = 0; j < temp; j++)
            //        Console.Write(" " + b[i, j]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("----------------------------------------------");
            //int[,] res = new int[col, temp];
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < temp; j++)
            //    {
            //        int sum = 0;
            //        for (int k = 0; k < col; k++)
            //            sum += a[i, k] * b[k, j];
            //        res[i, j] = sum;
            //    }
            //}
            //Console.WriteLine("NHAN MA TRAN");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < temp; j++)
            //        Console.Write(" " + res[i, j]);
            //    Console.WriteLine();
            //}


            // //Bai 6
            //int row, col;
            //Console.Write("Nhap so hang: ");
            //row = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot: ");
            //col = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------------------");
            //int[,] a = new int[row, col];
            //for (int i = 0; i < row; i++)
            //    for (int j = 0; j < col; j++)
            //    {
            //        Console.Write("Nhap phan tu: ");
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //Console.WriteLine("----------------------------------------");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("MA TRAN CHUYEN VI");
            //for (int j = 0; j < col; j++)
            //{
            //    for (int i = 0; i < row; i++)
            //        Console.Write(" " + a[i, j]);
            //    Console.WriteLine();
            //}


            // //Bai 7
            int row, col;
            Console.Write("Nhap so hang: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            col = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            int[,] a = new int[row, col];
            int[,] b = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Nhap phan tu mang a: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("--------------------------------------");

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Nhap phan tu mang b: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Mang A");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write(" " + a[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Mang B");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write(" " + b[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------");
            int sumOfSquares = 0;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    sumOfSquares += (a[i, j] - b[i, j]) * (a[i, j] - b[i, j]);
            double distance = Math.Sqrt(sumOfSquares);
            Console.Write("Khoang cach Euclid cua 2 ma tran = {0:0.00}",distance);

        }
    }
}
