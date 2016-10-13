
namespace CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var i0 = 1;
            var d0 = 1.1111;
            //i0 = d0; ->ne

            int i1 = i0;
            double d1 = d0;

            var s = new S();
            s.a = 1410;
            s.b = 14.10;
             
        }
    }
}
