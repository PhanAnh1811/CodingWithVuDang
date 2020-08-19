using System;

namespace Array_P2
{
    class Program
    {
        /*Ham nhap mang*/
        static void Input(int[] A, int n)
        {

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Phan tu thu {0}: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("------------------------------");
        }

        /*Ham xuat mang*/
        static void Output(int[] A)
        {
            Console.WriteLine("Mang A gom nhung phan tu");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("A[{0}] = {1}", i, A[i]);
            }
            Console.WriteLine("------------------------------");
        }

        /*Hoan vi phan tu cua mang*/
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /*Goi ham bai 1*/
        //static void Sort(int[] A, int k, int l)
        //{
        //    // K = 3,L=10;
        //    // 1 2 7 5 4 11 99
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (A[i] > k && A[i] < l)
        //        {
        //            for (int j = i + 1; j < A.Length; j++)
        //            {
        //                if (A[j] > k && A[j] < l)
        //                {
        //                    if (A[i] > A[j]) 
        //                        Swap(ref A[i], ref A[j]);
        //                }
        //            }
        //        }
        //    }
        //}

        /*Goi ham bai 2*/
        //static bool CheckSoNT(int x)
        //{
        //    int bienDem = 0;
        //    for (int i = 1; i <= x; i++)
        //    {
        //        if (x % i == 0)
        //            bienDem++;
        //    }
        //    if (bienDem == 2)
        //        return true;
        //    else
        //        return false;
        //}

        /*Cach 2*/
        //static bool CheckSoNT(int n)
        //{
        //    if (n < 2) return false;
        //    if (n < 4) return true;
        //    if (n % 2 == 0 || n % 3 == 0) return false;
        //    for (int i = 5; i * i <= n; i += 6)
        //        if (n % i == 0 || n % (i + 2) == 0)
        //            return false;
        //    return true;
        //}

        //static void SortPrime(int[] A)
        //{
        //    for (int i = 0; i < A.Length; i++)
        //        if (CheckSoNT(A[i]) == true)
        //            for (int j = i + 1; j < A.Length; j++)
        //                if (CheckSoNT(A[j]) == true)
        //                    if (A[i] < A[j])
        //                        Swap(ref A[i], ref A[j]);
        //}

        /*Goi ham bai 3*/
        //static int Search(int[] A, int k)
        //{
        //    return A[k - 1];
        //}
        //static void SortDecrease(int[] A)
        //{
        //    for (int i = 0; i < A.Length; i++)
        //        for (int j = i + 1; j < A.Length; j++)
        //            if (A[i] < A[j])
        //                Swap(ref A[i], ref A[j]);
        //}

        /*Goi ham bai 4*/
        //static int CountX(int x, int[] A)
        //{
        //    int count = 0;
        //    for (int i = 0; i < A.Length; i++)
        //        if (x == A[i])
        //            count++;
        //    return count;
        //}

        /*Goi ham bai 5*/
        //static void SortNew(int[] A, int k, int l)
        //{
        //    // K = 3,L=10;
        //    // 1 2 7 5 4 11 99
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        for (int j = i + 1; j < A.Length; j++)
        //        {
        //            if ((A[j] > k && A[j] < l) && (A[i] > k && A[i] < l))
        //            {
        //                if (A[i] > A[j])
        //                    Swap(ref A[i], ref A[j]);
        //            }
        //            else
        //            {
        //                if (A[i] < A[j])
        //                    Swap(ref A[i], ref A[j]);
        //            }
        //        }
        //    }
        //}

        /*Goi ham bai 6*/
        static int SearchMin(int[] A)
        {
            int min = A[0];
            int x = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    x = i + 1;
                }
                    
            }
            return x;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            int[] a = new int[n];
            Input(a, n);
            Output(a);

            // //Bai 1
            //int k, l;
            //do
            //{
            //    Console.Write("Nhap k: ");
            //    k = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap l: ");
            //    l = int.Parse(Console.ReadLine());
            //} while (k > l);
            //Sort(a, k, l);
            //Console.WriteLine("Sap xep cac phan tu trong doan tang dan");
            //Output(a);

            // //Bai 2
            //SortPrime(a);

            // //Bai 3
            //SortDecrease(a);
            //int k;
            //Console.Write("Nhap k: ");
            //k = int.Parse(Console.ReadLine());
            //Search(a, k);
            //Console.WriteLine("Phan tu lon thu {0} la {1}", k, Search(a, k));

            // //Bai4
            //int x;
            //Console.Write("Nhap gia tri x: ");
            //x = int.Parse(Console.ReadLine());
            //int res = CountX(x, a);
            //Console.WriteLine("So lan xuat hien phan tu co gia tri {0} la {1} lan", x, res);

            // //Bai 5;
            //int k, l;
            //do
            //{
            //    Console.Write("Nhap k: ");
            //    k = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap l: ");
            //    l = int.Parse(Console.ReadLine());
            //} while (k > l);
            //SortNew(a, k, l);
            //Console.WriteLine("Sap xep cac phan tu trong doan tang dan va ngoai doan giam dan");
            //Output(a);

            // //Bai 6
            int res = SearchMin(a);
            Console.WriteLine("vi tri phan tu nho nhat trong mang la " + res);
        }
    }
}

