using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class while_doLøkker
{
    static void Main(string[] args)
    {
        int t = 0; //tæller
        
        Console.WriteLine("Eksempel med en while-løkke");

        while(t<10)
        {
             Console.WriteLine(t.ToString());
             ++t; // Tæl t én op
        }

        Console.WriteLine("Eksempel med en do-løkke");

        int s = 0;
        
        do
        {
            Console.WriteLine(s.ToString());
        ++s;
        } while(s<10);
    }
}

//Output: Resultatet er det samme!  

