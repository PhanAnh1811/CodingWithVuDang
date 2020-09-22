using System;
using System.Buffers.Binary;
using System.Globalization;
using System.Text;

namespace String
{
    class Program
    {
        public static bool Check(string s)
        {
            if (s.Length < 8)
                return false;
            bool isLower = false;
            bool isUpper = false;
            bool isDigit = false;
            for(int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                    isLower = true;
                else if (char.IsUpper(s[i]))
                    isUpper = true;
                else if (char.IsDigit(s[i]))
                    isDigit = true;
            }
            if (!isLower || !isUpper || !isDigit)
                return false;
            return true;
        }
        
        static void Main(string[] args)
        {

            //Console.WriteLine("Code\tSymbol");

            // //Vi du 2
            //for(int i = 48; i <= 122; i++)
            //{
            //    Console.WriteLine(i + "\t" +(char)i);
            //}

            // //Vi du 3
            //for(char i = '0'; i < '\u00FF';  i++)
            //{
            //    Console.WriteLine('\u0000' + i + "\t" + '\u0000' + i.ToString());
            //}

            // //Bai 1
            //string s;
            //int countDiff = 0;
            //int temp = 0;
            //char res = ' ';
            //Console.Write("Nhap chuoi s: ");
            //s = Console.ReadLine();
            //int[] count = new int[1000];
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == ' ') continue;
            //    count[s[i]]++;
            //}
            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] > 0)
            //    {
            //        countDiff++;
            //        if (count[i] > temp)
            //        {
            //            temp = count[i];
            //            res = (char)i;
            //        }
            //    }
            //}
            //Console.WriteLine("So luong ky tu xuat hien: " + countDiff);
            //Console.WriteLine(res);

            // //Bai 2
            //string s;
            //Console.Write("Nhap eyes khau: ");
            //s = Console.ReadLine();
            //if (Check(s) == true)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            // //Bai 3
            //string s;
            //Console.Write("Nhap ho ten: ");
            //s = Console.ReadLine();
            //string[] cut = s.Split(' ');

            //Console.Write("Ho: " + cut[0]);
            //Console.WriteLine();

            //Console.Write("Ten: ");
            //for (int i = 1; i < cut.Length-1; i++)
            //{
            //    Console.Write(cut[i] + " ");                
            //}
            //Console.WriteLine();

            //Console.WriteLine("Ten lot: "+cut[cut.Length - 1]);

            // //Bai 6
            int x, y;
            string path;
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Nhap huong di cua robot: ");
            path = Console.ReadLine();
            //foreach(char step in path) // loop tung ky tu trong chuoi
            //{
            //    switch (step)
            //    {
            //        case 'D':
            //            x++;
            //            break;
            //        case 'T':
            //            x--;
            //            break;
            //        case 'N':
            //            y--;
            //            break;
            //        case 'B':
            //            y++;
            //            break;
            //    }
            //}
            //Console.WriteLine("{0} {1}", x, y);

            // //Bai 7
            char eyes = 'R';
            foreach(char step in path)
            {
                if (eyes == 'R')
                {
                    if (step == 'F')
                    {
                        x++;
                        eyes = 'R';
                    }
                    if (step == 'L')
                    {
                        y++;
                        eyes = 'F';
                    }
                    if(step == 'R')
                    {
                        y--;
                        eyes = 'B';
                    }
                    if (step == 'B')
                    {
                        x--;
                        eyes = 'L';
                    }
                }

                else if (eyes == 'L')
                {
                    if (step == 'F')
                    {
                        x--;
                        eyes = 'L';
                    }
                    if (step == 'L')
                    {
                        y--;
                        eyes = 'B';
                    }
                    if (step == 'R')
                    {
                        y++;
                        eyes = 'F';
                    }
                    if (step == 'B')
                    {
                        x++;
                        eyes = 'R';
                    }
                }

                else if (eyes == 'F')
                {
                    if (step == 'F')
                    {
                        y++;
                        eyes = 'F';
                    }
                    if (step == 'L')
                    {
                        x--;
                        eyes = 'L';
                    }
                    if (step == 'R')
                    {
                        x++;
                        eyes = 'R';
                    }
                    if (step == 'B')
                    {
                        y--;
                        eyes = 'B';
                    }
                }

                else if (eyes == 'B')
                {
                    if (step == 'F')
                    {
                        y--;
                        eyes = 'B';
                    }
                    if (step == 'L')
                    {
                        x++;
                        eyes = 'R';
                    }
                    if (step == 'R')
                    {
                        x--;
                        eyes = 'L';
                    }
                    if (step == 'B')
                    {
                        y++;
                        eyes = 'F';
                    }
                }
            }
            Console.WriteLine("{0} {1}", x, y);
        } 
    }
}
