using System;

namespace VariousTypes
{
    public class Program
    {   
        

        private static void Main(string[] args)
        {
         int numero = 8;
         float pi = 3.1415f;
         double x = 2.4567;
         uint l = 4U;
         long k = 3L;
         ulong n = 6UL;  
            
            Console.WriteLine($"isto é um inteiro: {numero}" );
            Console.WriteLine($"isto é um float: {pi}" );
            Console.WriteLine($"isto é um numero real: {x}" );
            Console.WriteLine($"isto é um literal uint: {l}" );
            Console.WriteLine($"isto é um literal long: {k}" );
            Console.WriteLine($"isto é um literal ulong: {n}" );


            char CheckMark = '\u2713';
            Console.WriteLine($"isto é um CheckMark: {CheckMark}" );
            char Star = '\u2605';
            Console.WriteLine($"isto é uma Star: {Star}" );
            char Hearth = '\u2764';
            Console.WriteLine($"isto é um Hearth: {Hearth}" );
            char Arrow = '\u2794';
            Console.WriteLine($"isto é um Arrow: {Arrow}" );
        }
    }
}
