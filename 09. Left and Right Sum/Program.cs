using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftSum = 0;
            int rightSum = 0;

            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < n; k++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }


            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }

        }
    }
}
