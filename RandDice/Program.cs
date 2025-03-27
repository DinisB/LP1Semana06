using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int sum = 0;
            if (args.Length != 2)
            {
                Console.WriteLine("You have to choose two arguments!");
                return;
            }
            int.TryParse(args[0], out int n);
            int.TryParse(args[1], out int s);

            Random random = new Random(s);

            for (int i = 0; i < n; i++)
            {
                sum += random.Next(1, 7);
            }

            Console.WriteLine(sum);
        }
    }
}
