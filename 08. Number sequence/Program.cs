using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minVal = int.MaxValue;
            int maxVal = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < minVal)
                {
                    minVal = input;
                }
                if (input > maxVal)
                {
                    maxVal = input;
                }
            }
            Console.WriteLine($"Max number: {maxVal}");
            Console.WriteLine($"Min number: {minVal}");
        }
    }
}
