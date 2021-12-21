using System;

namespace Task_3
{
    internal class Program_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Int32.Parse(Console.ReadLine());
            int[] freq = { 0, 0 };
            do
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    ++freq[0];
                }
                else
                {
                    ++freq[1];
                }
            } while ((n /= 10) != 0);
            Console.WriteLine($"{freq[0]} чётных, {freq[1]} нечётных");
        }
    }
}
