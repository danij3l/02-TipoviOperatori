using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();
            
            Osoba osoba = new Osoba();

            bool bitiIliNeBitiStudent= janko is Student;
            bool bitiIliNeBitiOsoba = janko is Osoba;

            Console.WriteLine(bitiIliNeBitiStudent);
            Console.WriteLine(bitiIliNeBitiOsoba);

            bitiIliNeBitiStudent = osoba is Student;
            bitiIliNeBitiOsoba = osoba is Osoba;

            Console.WriteLine(bitiIliNeBitiStudent);
            Console.WriteLine(bitiIliNeBitiOsoba);



            Console.ReadKey();
        }
    }
}
