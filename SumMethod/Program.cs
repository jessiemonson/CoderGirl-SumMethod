using System;

namespace SumMethod
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Pick a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = Sum(number);
            Console.WriteLine(sum);

            Console.ReadLine();
        }
        public static int Sum(int number)
        {
            int sum = (number * (number + 1) / 2);
            return sum;


            // TODO: Create a method that returns the sum of all integer numbers up to and including given value. 
            // Use the equation (n * (n + 1)) / 2.
        }
    }
}
