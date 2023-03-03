using System;
using System.Text;



namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;
            Console.OutputEncoding = Encoding.UTF8;

            //váriaveis do Tipo string
            string message = "Bom dia";
            string c = @"""Esta string esta' entre aspas""";
            string x = "um \u10331";
            string y = "dois \u10332";
            string t = "3 \u10347";

            //print das váriaveis
            Console.WriteLine(message);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(t);
            Console.WriteLine();

            //strings com concatenação
            string o = "boo" + 3;
              Console.WriteLine(o);
            string p = "abc " + x;
            Console.WriteLine(p);
            string h = $"valor de x é {x}";
            Console.WriteLine(h);
            string j = $"{x} + {y} é igual a {x + y}";
            Console.WriteLine(j);
            string u =string.Format("y é {1}, x é{0}", x, y);
            Console.WriteLine(u);
            Console.WriteLine(@"Verbatim com x={0}",x);

            //imprimir as váriaveis com a formatação pedida
           Console.WriteLine($"{xx:f2}");
           Console.WriteLine($"{xx:p1}");

           Console.WriteLine($"{ii:x}");
           Console.WriteLine($"{ii:c}");












 



        }
    }
}
