using System;

namespace Task_2
{
    internal class Program_2
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double product = 1;
            for (int k = 1; k <= 6; k++)
            {
                double element = 1.0 / (Math.Pow(k, 3 - Math.PI) - 1);
                Console.WriteLine(element);
                sum += element;
                product *= element;
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
        }
    }
}
