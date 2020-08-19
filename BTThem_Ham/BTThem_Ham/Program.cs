using System;

namespace BTThem_Ham
{
    class Program
    {
        // //Goi ham bai 1
        //static int VanToc(int s,int t)
        //{
        //    int v;
        //    v = s / t;
        //    return v;
        //}

        // //Goi ham bai 2
        //static bool CheckVowel(char vowel)
        //{
        //    switch (vowel)
        //    {
        //        case 'u':
        //        case 'e':
        //        case 'o':
        //        case 'a':
        //        case 'i':
        //            return true;
        //        default:
        //            return false; 
        //    }
        //}

        // //Goi ham bai 3
        //static void PTBacHai(double a, double b, double c)
        //{
        //    double delta = 0;
        //    double x1, x2;
        //    delta = (b * b) - (4 * a * c);
        //    if (delta > 0)
        //    {
        //        Console.WriteLine("PT co 2 nghiem phan biet");
        //        x1 = (-b + Math.Sqrt(delta)) / 2;
        //        x2 = (-b + Math.Sqrt(delta)) / 2;
        //        Console.WriteLine("x1={0:0.00}, x2={1:0.00}", x1, x2);
        //    }
        //    if (delta == 0)
        //    {
        //        Console.WriteLine("PT co 1 nghiem duy nhat");
        //        x1 = x2 = -b / (2 * a);
        //        Console.WriteLine("x1=x2= " + x1);
        //    }
        //    else if (delta < 0) 
        //    {
        //        Console.WriteLine("PT vo nghiem");
        //    }   
        //}

        // //Goi ham bai 4
        //static int Reserve(int n)
        //{
        //    //1234
        //    int num = 0;
        //    while (n != 0)
        //    {
        //        int last = n % 10; //lấy chữ số cuối = 4
        //        num = num * 10 + last; 
        //        n /= 10; //Bỏ chữ số cuối = 123

        //    }
        //    return num;
        //}

        // //Goi ham bai 5
        //static bool CheckSoNT(int n)
        //{
        //    int bienDem = 0;
        //    for(int i = 1; i <= n; i++)
        //    {
        //        if (n % i == 0)
        //            bienDem++;
        //    }
        //    if (bienDem == 2)
        //        return true;
        //    else
        //        return false;
        //}
        //static int TinhTongSoNT(int n)
        //{
        //    int sum = 0;
        //    for(int i = 1; i <= n; i++)
        //    {
        //        if (CheckSoNT(n))
        //            sum += i;
        //    }
        //    return sum;
        //}

        // //Goi ham bai 6
        //static bool CheckIsDivisor(int n)
        //{
        //    int sumOfDivisor = 0;
        //    for(int i = 1; i < n; i++)          
        //        if (n % i == 0)                 
        //            sumOfDivisor += i;
        //    return sumOfDivisor == n ? true : false; // toán tử 3 ngôi
        //}
        //static int TinhSoHoanHao(int n)
        //{
        //    int sum = 0;
        //    for(int i = 1; i < n; i++)
        //        if (n % i == 0)
        //            sum += i;
        //    return sum;
        //}

        // //Goi ham bai 7
        //static bool Check(int n)
        //{
        //    int a;
        //    a = (int)Math.Sqrt(n);
        //    if (a * a == n)
        //        return true;
        //    else
        //        return false;
        //}
        //static int TinhSumChinhPhuong(int n)
        //{
        //    int sum = 0;
        //    int a = (int)Math.Sqrt(n);
        //    for(int i = 1; i <= n; i++)
        //    {
        //        if (Check(i))
        //            sum += i;
        //    }
        //    return sum;
        //}

        // //Goi ham bai 8
        //static bool CheckPalindrome(int n)
        //{
        //    int last;
        //    int sum = 0;
        //    int temp = n;
        //    while (n != 0) //while (n > 0 )
        //    {
        //        //121
        //        last = n % 10; //lay so 1
        //        sum = (sum * 10) + last;
        //        n /= 10; //bo so 1
        //    }
        //    // //Cach 1
        //    //if (temp == sum)
        //    //    return true;
        //    //else
        //    //    return false;
        //    // //Cach 2
        //    return temp == sum ? true : false;
        //}

        // //Goi ham bai 9
        //static int MaxOfDigits(int n)
        //{
        //    int max = 0;
        //    while (n > 0) //khi nao n <=0 thi pause
        //    {
        //        //1349
        //        int temp = n % 10;
        //        n /= 10;
        //        if (temp > max)
        //            max = temp;
        //    }
        //    return max;
        //}
        //static int MinOfDigits(int n)
        //{
        //    int min = 9999;
        //    while (n > 0)
        //    {
        //        int temp = n % 10;
        //        n /= 10;
        //        if (temp < min)
        //            min = temp;

        //    }
        //    return min;
        //}

        // //Goi ham bai 10
        //static void FindOfDigits(int n,int k)
        //{
        //    while (n > 0)
        //    {
        //        int temp = n % 10;
        //        n /= 10;
        //        if (temp > k)
        //        {
        //            Console.WriteLine("Cac chu so lon hon k: " + temp);
        //        }
        //    }
        //}

        // //Goi ham bai 11
        //static int MultiDivisor(int n, int k)
        //{
        //    int nhan = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            if (i % 2 == 0 && i > k)
        //                nhan *= i;
        //        }
        //    }
        //    return nhan;
        //}

        // //Goi ham bai 12
        //static int Digits(int n)
        //{
        //    int sum = 0;
        //    int multi = 1;
        //    while (n > 0)
        //    {
        //        int temp = n % 10;
        //        n /= 10;
        //        if (temp % 2 == 0)
        //        {
        //            multi *= temp;
        //            Console.WriteLine("Tich cua chu so le la " + multi);
        //        }
        //        else
        //        {
        //            sum += temp;
        //            Console.WriteLine("Tong cua chu so chan la " + sum);
        //        }
        //    }
        //    return sum + multi;
        //}

        // //Hãy viết một hàm kiểm tra một số có phải số ThanhVan không?
        static bool CheckSoNT(int n)
        {
            int bienDem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    bienDem++;
            }
            if (bienDem == 2)
                return true;
            else
                return false;
        }
        //static bool IsPrime(int n)
        //{
        //    if (n < 2) return false;
        //    if (n < 4) return true;
        //    if (n % 2 == 0 || n % 3 == 0) return false;
        //    for (int i = 5; i * i <= n; i += 6)
        //        if (n % i == 0 || n % (i + 2) == 0)
        //            return false;
        //    return true;
        //}
        static bool CountDigitPrime(int n)
        {
            int count = 0;
            while (n != 0)
            { //3315
                if (CheckSoNT(n % 10))
                    count++;
                n /= 10;
            }
            if (count >= 2) return true;
            return false;
        }

        static bool SumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum % 2 == 0 ? true : false;
        }

        static bool IsIncreaseLeftToRight(int n)
        {
            // 0307
            int maxComp = n % 10;
            n /= 10;
            while (n != 0)
            {
                if (n % 10 > maxComp)
                    return false;
                n /= 10;
            }
            return true;
        }

        static bool IsThanhVan(int n)
        {
            return
                (CountDigitPrime(n) &&
                SumOfEvenDigits(n) &&
                IsIncreaseLeftToRight(n))
                ? true : false;
        }

        /*
           Viết chương trình duyệt tất cả các số từ 1 đến 100.
         - Nếu số đang duyệt là bội số của 3, in "Sugar"
         - Nếu số đang duyệt là bội số của 5, in "Baby"
         - Nếu số đang duyệt là bội số của cả 3 và 5, in "SugarBaby"
        */
        static void SugarBaby()
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("Sugar");
                if (i % 5 == 0)
                    Console.WriteLine("Baby");
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("SugarBaby");
            }
        }

        /*Nhập một tháng trong năm (giả sử nhập đúng), 
        in ra quý chứa tháng đó. Biết một năm có 4 quý, mỗi quý có 3 tháng.*/
        static int Precious(int month)
        {
            return (month - 1) / 3 + 1;
        }

        static void Main(string[] args)
        {
            // //Bai 1
            //int s, t;
            //Console.Write("Nhap s: ");
            //s = int.Parse(Console.ReadLine());
            //Console.Write("Nhap t: ");
            //t = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int res = VanToc(s, t);
            //Console.WriteLine("Van toc = " + res);

            // //Bai 2
            //char n;
            //Console.Write("Nhap ky tu: ");
            //n = Convert.ToChar(Console.ReadLine());
            //if (CheckVowel(n))
            //{
            //    Console.WriteLine("Day la nguyen am");
            //}
            //else
            //{
            //    Console.WriteLine("Day la phu am");
            //}

            // //Bai 3
            //double a, b, c;
            //Console.Write("Nhap a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = double.Parse(Console.ReadLine());
            //Console.Write("Nhap c: ");
            //c = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("PT bac 2 co dang: {0}x^2+ {1}x+ {2} = 0", a, b, c);
            //PTBacHai(a, b, c);

            // //Bai 4
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //int res = Reserve(n);
            //Console.WriteLine("Day so sao khi doi nguoc: "+res);

            // //Bai 5
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (CheckSoNT(n))
            //{
            //    Console.WriteLine("la so nguyen to");
            //    int res = TinhTongSoNT(n);
            //    Console.WriteLine("Tong cac so nguyen to la " + res);
            //} 
            //else
            //    Console.WriteLine("Khong la so nguyen to");

            // //Bai 6
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (CheckIsDivisor(n))
            //{
            //    Console.WriteLine("So hoan hao");
            //    int res = TinhSoHoanHao(n);
            //    Console.WriteLine("Tong la " + res);
            //}
            //else
            //{
            //    Console.WriteLine("Khong la so hoan hao");
            //}

            // //Bai 7
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (Check(n)) 
            //{
            //    Console.WriteLine("So chinh phuong");
            //    int res = TinhSumChinhPhuong(n);
            //    Console.WriteLine("Tong cac so chinh phuong la " + res);
            //}
            //else
            //    Console.WriteLine("Khong phai so chinh phuong");

            // //Bai 8
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (CheckPalindrome(n))
            //    Console.WriteLine("La so doi xung");
            //else
            //    Console.WriteLine("Khong phai la so doi xung");

            // //Bai 9
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int outPut1 = MaxOfDigits(n);
            //Console.WriteLine("Chu so lon nhat la " + outPut1);
            //int outPut2 = MinOfDigits(n);
            //Console.WriteLine("Chu so nho nhat la " + outPut2);

            // //Bai 10
            //int n, k;
            //Console.Write("nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("nhap k: ");
            //k = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //FindOfDigits(n, k);

            // //Bai 11
            //int n,k;
            //Console.Write("nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.Write("nhap k: ");
            //k = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int res = MultiDivisor(n,k);
            //Console.WriteLine("Tich cac uoc so la " + res);

            //Bai 12
            //int n;
            //Console.Write("Nhap n: ");
            //n = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //int res = Digits(n);
            //Console.WriteLine(" " + res); 

            // //Hãy viết một hàm kiểm tra một số có phải số ThanhVan không?

            /*
             Viết chương trình duyệt tất cả các số từ 1 đến 100.
            - Nếu số đang duyệt là bội số của 3, in "Sugar"
           - Nếu số đang duyệt là bội số của 5, in "Baby"
           - Nếu số đang duyệt là bội số của cả 3 và 5, in "SugarBaby"
            */
            //SugarBaby();
            //Console.WriteLine(Precious(9));
            if (IsThanhVan(220221))
                    Console.WriteLine("OK THANH VAN NUMBER");
            else Console.WriteLine("INVALID NUMBER");
            Console.ReadKey();
        }
    }
}
