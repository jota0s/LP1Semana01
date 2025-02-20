using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string star = "\u2605";
            string heart = "\u279C";
            string flag = "\u2690";  

            Console.WriteLine("this is a star" + star);
            Console.WriteLine("this is a star" + heart);
            Console.WriteLine("this is a star" + flag);


            Console.WriteLine($"this is a {star}");
            Console.WriteLine($"this is a {heart}");
            Console.WriteLine($"this is a {flag}");
        }
    }
}
