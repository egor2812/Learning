using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
