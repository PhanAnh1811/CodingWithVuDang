using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Sort
{
    class Program
    {
        static void Input(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Mang ban dau: ");
            for (int i = 0; i <a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        
        static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void SelectionSort(int n, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
            }
        }

        static void QuickSort(int [] a,int left,int right)
        {
            // 9 4 3 1 5
            int i = left; // 0
            int j = right; // 4
            int x = a[(left + right) / 2]; // 3
            while (i < j)
            {
                while (a[i] < x) // 9 < 3
                    i++;
                while (x < a[j]) // 3 < 5
                    j--; // j= 3
                if (i <= j) // 0 <= 3
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    // 1 4 3 9 5
                    i++; // i=1
                    j--; // j=2
                }

                if (left < j) 
                    QuickSort(a, left, j);
                if (i < right)
                    QuickSort(a, i, right);
            }
        }

        static int Processing(int[] a, int n)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i + 1])
                    continue;
                if (a[i + 1] != a[i] + 1)
                    return a[i] + 1;
            }
            return 0;  
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("-------------------------------------------");
            Input(a);
            SelectionSort(n, a);
            Console.WriteLine();
            //QuickSort(a, 0, a.Length - 1);

            // //Counting Sort
            //int[] count = new int[n + 100];
            //for (int i = 0; i < count.Length; i++)
            //    count[i] = 0;
            //for (int i = 0; i < a.Length; i++)
            //    count[a[i]]++;
            //Console.WriteLine();
            Console.Write("Mang sau khi sap xep: ");

            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] > 0)
            //    {
            //        int rank = count[i];
            //        while (rank-- > 0)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}
            Output(a);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("So nho nhat trong a: "+Processing(a,n));

            // //Bai 5
            int count = 1;
            for (int i = 0; i < a.Length - 1; i++) 
            {
                if (a[i] != a[i + 1])
                    count++;
            }
            Console.WriteLine("So luong so khac nhau la " + count);
        }
    }
}
