using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeričkaPromocija
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            Console.WriteLine(a/b); //zaokruživnaje na najbližu vrijednost
            double d = 5;

            Console.WriteLine(GetType(d + a)); 
            

            Console.ReadKey();
        }

        private static bool GetType(double d)
        {
            throw new NotImplementedException();
        }
    }
}
