using System;

namespace BT_Array
{
    class Program
    {
        /*Goi ham bai 2*/
        static int Search(int x, int[] A)
        {
            Console.Write("Nhap gia tri x: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < A.Length; i++)
            {
                if (x == A[i])
                {
                    return i + 1;
                }
            }
            return -1;
        }

        /*Goi ham bai 3*/
        //static int Max(int[] A)
        //{
        //    int max = A[0];
        //    for (int i = 0; i < A.Length; i++) 
        //    {
        //        if (max < A[i])
        //        {
        //            max = A[i];
        //        }
        //    }
        //    return max;
        //}

        /*Goi ham bai 4*/
        //static void Sort(int[] A)
        //{
        //    for(int i = 0; i < A.Length; i++)
        //    {
        //        for(int j = i + 1; j < A.Length; j++)
        //        {
        //            if (A[i] < A[j])
        //            {
        //                int temp = A[i];
        //                A[i] = A[j];
        //                A[j] = temp;
        //            }
        //        }  
        //    }
        //    Console.Write("Mang duoc sap xep giam dan:");
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        Console.Write(" " + A[i]);
        //    }
        //}

        /*Goi ham bai 5*/
        //static double Average(int[] A,int n)
        //{
        //    double avg = 0;
        //    int sum = 0;
        //    for(int i = 0; i < A.Length; i++)
        //    {
        //        sum += A[i]; 
        //    }
        //    avg = (double)sum / n;
        //    return avg;
        //}

        /*Goi ham bai 6*/
        //static int Count(int[] A)
        //{
        //    int count = 0;
        //    for(int i = 0; i < A.Length; i++)
        //    {
        //        if (A[i] % 2 == 0)
        //            count++;
        //    }
        //    return count;
        //}

        /*Goi ham bai 7*/
        //static int CountX(int x, int[] A)
        //{
        //    int count = 0;
        //    Console.Write("Nhap gia tri x can tim: ");
        //    x = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if (x == A[i])
        //            count++;
        //    }
        //    return count;
        //}
        static void Main(string[] args)
        {
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

            // //Bai 1
            //int sum = 0;
            //for(int i = 0; i < A.Length; i++)
            //{
            //    sum += A[i];
            //}
            //Console.WriteLine("Tong la " + sum);

            // //Bai 2
            int x = 0;
            int res = Search(x, A);
            Console.WriteLine("Gia tri x nam o vi tri: " + res);

            // //Bai 3
            //int res = Max(A);
            //Console.WriteLine("Gia tri lon nhat la " + res);

            // //Bai 4
            //Sort(A);

            // //Bai 5
            //double res = Average(A,n);
            //Console.WriteLine("Trung binh cong: {0:0.0}", res);

            // //Bai 6
            //int res = Count(A);
            //Console.WriteLine("Co {0} phan tu la so chan trong mang", res);

            // //Bai 7
            //int x = 0;
            //int res = CountX(x, A);
            //Console.WriteLine("Co {0} phan tu co gia tri x trong mang", res);
        }
    }
}
