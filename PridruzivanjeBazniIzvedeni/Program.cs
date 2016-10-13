﻿
namespace CSharp.TipoviOperatori
{
    class Osoba
    {
        public string DajOib()
        {
            return "0123456789";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.DajOib();
            
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            //osobaStudent.PoložiIspit(CSharp);

            Student danijel = new Student();
            danijel.DajOib();
            danijel.PoložiIspit("CSharp");




        }
    }
}
