using System;
using System.Text;



namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string message = "Bom dia";
            string c = @"""Esta string esta' entre aspas""";
            string x = "um \u10331";
            string y = "dois \u10332";
            string t = "3 \u10347";
            Console.WriteLine(message);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(t);
        }
    }
}
