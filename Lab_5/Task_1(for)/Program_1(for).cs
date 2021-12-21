using System;

namespace Task_1_for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int k = 1; k <= 10; k++)
            {
                for (int i = -10; i <= 10; i++)
                {
                    Console.Write(Math.Round(1.0 / (Math.Pow(k, 3 - Math.PI) - 1), 5) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
