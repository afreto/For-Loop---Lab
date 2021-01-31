using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMashinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double savedMoney = 0;
            int moneyToGive = 10;
            int numToys = 0;
            for (int i = 1; i <= age; i++)
            {
                switch (i % 2)
                {
                    case 0:
                        savedMoney += moneyToGive - 1;
                        moneyToGive += 10;
                        break;
                    default:
                        numToys++;
                        break;
                }
            }
            savedMoney += numToys * toyPrice;
            if (savedMoney >= washMashinePrice)
            {
                double diff = savedMoney - washMashinePrice;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                double diff = washMashinePrice - savedMoney;
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
