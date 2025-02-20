using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("insert a number: ");
            string n =Console.ReadLine();
            int c = int.Parse( n );
            Console.WriteLine("insert a number with decimal: ");
            string d =Console.ReadLine();
            float f = float .Parse( d);
            Console.WriteLine($"this is the sum of the numbers: {c + f}");
        }
    }
}
