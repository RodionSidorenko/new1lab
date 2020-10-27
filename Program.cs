using System;

namespace new_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число х:\n");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x <-5 && x >-10 & x <= 4.5 && x >= -4.5)
            {
                double y = Math.Cos(Math.Pow(x, 2))/(Math.Pow(Math.Sin(2*x), 2)+1);
                Console.WriteLine(y);
            }

            else
            {
                double y = (Math.Pow(-x, 2) + 3)/(2 - x);
                Console.WriteLine(y);
        }
    }
    }
}