using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcesDemo
{
    class ProcesDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn : ");
            string MitNavn = Console.ReadLine();
            Console.WriteLine("Navnet er: {0}", MitNavn);

            //Exception handling: 
            
            int a, b, c;

            a = 2;
            b = 2;
            c = a / b;

            Console.WriteLine("{1}" , c);


        }
    }
}
