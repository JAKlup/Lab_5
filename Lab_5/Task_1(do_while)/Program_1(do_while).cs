using System;

namespace Task_1_do_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            do
            {
                int i = -10;
                do
                {
                    Console.Write(Math.Round(1.0 / (Math.Pow(k, 3 - Math.PI) - 1), 5) + " ");
                    i++;
                } while (i <= 10);
                Console.WriteLine();
                k++;
            } while (k <= 10);
        }
    }
}
