using System;
using System.Collections.Generic;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad7(args);
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
        //С 5-ой задачей 1-го задания возникли некоторые проблемы.  Хотелось бы их разобрать на следующем занятии
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
            bool prost = true;
            int n = rnd.Next();
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                return(true);
            }
            else
            {
                return(false);
            }
           
        }
        static bool Zad8(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            bool prost = true;
            int n = rnd.Next(a,b);
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                return (true);
            }
            else
            {
                return (false);
            }
            
        }
        //С задачами 4 и 5 задания 2 возникли трудности. Хотелось бы их разобрать на следующем занятии
    }
}
