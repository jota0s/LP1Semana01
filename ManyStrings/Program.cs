﻿using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {   
            double xx = 1.23456;
            int ii = 19;
            string star = "\u2605";
            string heart = "\u279C";
            string flag = "\u2690";  

            Console.WriteLine("this is a star" + star);
            Console.WriteLine("this is a star" + heart);
            Console.WriteLine("this is a star" + flag);


            Console.WriteLine($"this is a {star}");
            Console.WriteLine($"this is a {heart}");
            Console.WriteLine($"this is a {flag}");

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");

            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");
        }
    }
}
