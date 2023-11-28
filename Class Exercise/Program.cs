using System.Globalization;

namespace Class_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mynumbers = { 2, 1, 7, 4, 9, 5 };

            int biggest = Number.BiggestNumber(mynumbers);

            Console.WriteLine("The Biggest number is" + biggest);

            int secondbiggest = Number.SecondbiggestNumber(mynumbers);
            Console.WriteLine("The Second Biggest Number is" + secondbiggest);
        }

    }
}
