using System;

namespace Libaryunction
{
    public class Program

    { 

        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int even = int.Parse(Console.ReadLine());
            Console.WriteLine(Even(even));

            Console.WriteLine("enter a number");
            int Odd = int.Parse(Console.ReadLine());
            Console.WriteLine(IsOdd(Odd));

            Console.WriteLine("enter a number");
            int pr = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(pr));

            Console.WriteLine("enter a number");
            int  = int.Parse(Console.ReadLine());
            Console.WriteLine(IsOdd(Odd));

            Console.WriteLine(IsOdd(3));
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(Square(2));
            Console.WriteLine(Cube(2));
            //Console.WriteLine(Ceil(2, 3));
            //Console.WriteLine(Floor(2, 3));

        }
        static bool Even(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }

            return false;


        }

        static bool IsOdd(int n)
        {
            int Odd;
            Odd = n;
            if (n % 2 != 0)
            {
                return true;
            }
            
                return false;
            
        }
        static bool IsPrime(int n)
        {
            int pr = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
        static int Square(int n)
        {
            int Square = n;
            Square = n * n;
            return Square;
        }
        static int Cube(int n)
        {
            int Cube = 0;
            Cube = Square(n) * n;
            return Cube;
        }
        public static int Ceil(float x)
        {
            int Ceil = (int)x + 1;
            if (x < 0)
            {
                Ceil = (int)x;
            }
            if (x > 0)
            {
                if (x > Ceil)
                {
                    Ceil = Ceil + 1;
                }
            }
            return Ceil;
        }

        public static int FLoor(float x)
        {
            int n = (int)x;
            if (x < 0)
            {
                if (n > x)
                {
                    n = n - 1;
                }
            }
            return n;
        }

        public static int Pow(int x, int y)
        {
            int R = 0;
            for (int i = 1; i <= y; i++)
            {
                R = R * 1;
            }
            return R;
        }


        public static double Rand2()
        {
           
            Random rd = new Random();
            double num = rd.NextDouble();
            return num;
        }
        public static int Rand1()
        {
            
            Random JAV = new Random();
            int rs = JAV.Next(0, 2 ^ 31 - 1);
            return rs;
        }
        public static long Factorial(long n)
        {
            int gt = 1;

            for (int i = 1; i <= n; i++)
            {
                gt = gt * i;
            }
            return gt;
        }
    }

}



