using System;
using Timer = System.Timers.Timer;

namespace nsMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = TimeSpan.FromSeconds(10).TotalMilliseconds;
            timer.Elapsed += (sender, e) => Math();
            timer.Enabled = true;

            Console.WriteLine("Wait for it..");
            Console.ReadLine();
        }

        private static void Math()
        {
            int num1 = 10;
            int num2 = 5;

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            double quotient = (double)num1 / num2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }
}

