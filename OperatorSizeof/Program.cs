using System;

namespace CSharp.TipoviOperatori
{
    struct MojaStruktura
    {
        decimal a;
        double b;
    }

    struct MojaSloženaStruktura
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;

    }

    class MojaKlasa
    {
        public void IspišiSe()
        {
            Console.WriteLine(this.ToString());
        }

        decimal a;
        double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(decimal));

            Console.WriteLine(sizeof(double));

            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaStruktura)));

            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaSloženaStruktura)));

            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(MojaKlasa)));

            Console.ReadKey();
        }
    }
}
