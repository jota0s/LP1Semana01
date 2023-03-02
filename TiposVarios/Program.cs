using System;
using System.Text;
namespace TiposVarios
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //declarar váriaveis e atribuir valor
            int p = 10; 
            int x = 20;
            System.Console.WriteLine(p);
            System.Console.WriteLine(x);

            //declarar váriaveis do tipo char com diferentes símbolos
            char Symbol = '\u2190';
            Console.WriteLine(Symbol);
            char Symbol2 = '\u2194';
            Console.WriteLine(Symbol2);

            //declarar váriaveis reais 
            float t = 1.3913f;
            Console.WriteLine(t);
            double y = 1.4567;
            Console.WriteLine(y);
            

        }

    
    }
}
