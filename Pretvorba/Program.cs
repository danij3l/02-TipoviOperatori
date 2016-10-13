using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pretvorba
{
    class Osoba
    {
        public string DajSvojOib()
        {
            return "1234567890";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 5;
        }
    }

    class Radnik : Osoba
    {
        public bool Napravi(string proizvod)
        {
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.DajSvojOib();
            student.PoložiIspit("CSharp");


            Osoba osobaS = student;
            osobaS.DajSvojOib();

            Student sos = (Student)osobaS;
            sos.DajSvojOib();
            sos.PoložiIspit("CSharp");
   

            Osoba osobaR = new Radnik();
            osobaR.DajSvojOib();


            Student sor = (Student)osobaR;
            sor.DajSvojOib();
            sor.PoložiIspit("CSharp");

        }
    }
}
