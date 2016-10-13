using System;

namespace CSharp.UgrađeniBrojčaniTipovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            int x = int.MaxValue;
            x = x + 1;
            Console.WriteLine(x); 
            int y = int.MinValue;
            y = y - 1;
            Console.WriteLine(y);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            //Console.WriteLine(1/0); nije dozvoljeno dijeljenje s nulom
            //Console.WriteLine(-1/0); nije dozvoljeno dijeljenje s nulom
            double d = 0;
            Console.WriteLine(d/0); //NaN

            Console.ReadKey();
        }
    }
}
