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
        }
    }
}
