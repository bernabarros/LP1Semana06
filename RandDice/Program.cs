using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random dice_seed = new Random(int.Parse(args[1]));
            int sum_result = 0;

            for(int n = 1; n <= int.Parse(args[0]); n++)
            {
                sum_result += dice_seed.Next(1,7);
            }

            Console.WriteLine($"{sum_result}");
        }
    }
}
