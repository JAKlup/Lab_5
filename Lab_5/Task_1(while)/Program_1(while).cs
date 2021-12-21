using System;

namespace Task_1_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            while (k <= 10)
            {
                int i = -10;
                while (i <= 10)
                {
                    Console.Write(Math.Round(1.0 / (Math.Pow(k, 3 - Math.PI) - 1), 5) + " ");
                    i++;
                }
                Console.WriteLine();
                k++;
            }
        }
    }
}
