using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace Search
{
    class Program
    {
        static void Input(int[] a, int n)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap phan tu: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Mang ban dau: ");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
        }
        static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write(a[i] + " ");
            }
        }
        static void QuickSort(int[] a, int left, int right)
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
        static int BinarySearch(int[] a, int x)
        {
            int left = 0;
            int right = a.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (x == a[mid])
                    return mid;
                if (x < a[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }
        static int BinarySearchNumber(int[] a, int left, int right, int x)
        {
            while (left<=right)
            {
                int mid = (left + right) / 2;

                if (a[mid] == x) 
                    return mid;
                if (a[mid] > x) 
                    BinarySearchNumber(a, left, mid - 1, x);
                return BinarySearchNumber(a, mid + 1, right, x);
            }

            return -1;
        }
        static bool Processing(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {            
                if (a[i] >= 0)
                    return false;
                if (BinarySearchNumber(a, i, a.Length - 1, -a[i]) != -1) 
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            int[] a = new int[n];
            Input(a, n);
            Console.WriteLine();
            QuickSort(a, 0, a.Length - 1);
            Console.WriteLine("Mang sau khi sap xep: ");
            Output(a);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            //int x;
            //Console.Write("Nhap x: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Vi tri xuat hien x: " + BinarySearch(a, x));
            Console.WriteLine("Trong mang co so doi khong?");
            if (Processing(a) == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            
        }
    }
}
