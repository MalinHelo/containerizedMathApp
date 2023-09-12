using System;
using Timer = System.Timers.Timer;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = TimeSpan.FromSeconds(10).TotalMilliseconds;

            // Subscribe to the Elapsed event and specify the method to execute
            timer.Elapsed += TimerElapsed;

            // Start the timer
            timer.Start();

            // Keep the program running
            Console.WriteLine("Wait for it..");
            Console.ReadLine();
        }

        private static void TimerElapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Math();
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

