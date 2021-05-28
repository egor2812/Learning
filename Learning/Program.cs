using System;
using System.Collections.Generic;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Prost(10));
        }
        static void Zad1(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> d = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    d.Add(i);
            }

            foreach (int item in d)
            {
                Console.WriteLine(item + " ");
            }
        }
        static void Zad2(string[] args)
        {
            bool p = true;
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    p = false;
                    break;
                }
            }
            if (p)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();
        }
        static void Zad3(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Pow(a, 3) - Math.Pow(b, 2)));
        }
        static void Zad4(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine((Math.Pow((Math.Pow(a + b, 2)), 1 / 3.0)) / (Math.Log(c)));
        }
        static void Zad5(string[] args)
        {
           for(int i = 0; i > 50; i++)
            {
                int a = 2;
                double q = 0.9;
                Console.WriteLine(a*Math.Pow(q,i));
                //также возможен вариант Console.WriteLine(2*Math.Pow(0.9,i));
            }
        }
        
        static void Zad6(string[] args)
        {
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static bool Zad7(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next();
            if (Prost(n) == true)
            {
                return true;
            }
            return false;
           
        }
        static bool Prost(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool Zad8(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int n = rnd.Next(a,b);
            if (Prost(n) == true)
            {
                return true;
            }
            return false;

        }
        static void Zad9(string[] args)
        {
            double a = 0;
            double sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                a = (2 * i - 1) / Math.Pow(2, i);
                if (i % 2 == 0 || i==1)
                {
                    sum += a;
                }
                else
                {
                    sum -= a;
                }
                Console.WriteLine(sum);
            }
        }
        static double Zad10(double a)
        {
            double cosx = 0;
           for(int i = 1; i <= 100; i++)
            {
                double cosxlast = cosx;
                cosx += Math.Round(Math.Pow(-1, i) * Math.Pow(a, 2 * i) / Factorial(2 * i), 32);
                if (cosx == cosxlast)
                {
                    break;
                }
            }
            return cosx;
        }
        static long Factorial(int f)
        {
            long sum = 1;
            for(int i=f; i > 0; i--)
            {
               sum *= i;
            }
            return sum;
        }
    }
}
