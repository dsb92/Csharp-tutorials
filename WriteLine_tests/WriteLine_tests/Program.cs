using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Eksperimentér med WriteLine og opdage de mange måder, du kan manipulere med dit output på.

namespace WriteLine_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string Navn = "Jacob";
            int Alder = 18;

            Console.WriteLine("Hej {0}! Du er {1} år gammel.", Navn, Alder); 
            
            Console.WriteLine("{0:D23}", 10);  //Heltal(int)
            
            Console.WriteLine("{0:E}", 23);   //Scientific(eksponential)

            Console.WriteLine("{0:F}", 12);  //Flydende tal(decimaltal)

            Console.WriteLine("{0:N2}", 1000000000); // Nummer med tusindadskillelse

            Console.WriteLine("{0:P}", 0.05);  //Procent

            Console.WriteLine("{0:X}", 119); //Hexadecimalt

            
        }
    }

    
}
