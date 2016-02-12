using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LøkkeSammenligning
{
    static void Main(string[] args)
    {
        int[] MitArr = new int[] { 12, 14, 18, 18 };

        Console.WriteLine("Gennemløb af array med for-løkken");

        for (int t = 0; t < MitArr.GetLength(0); t++)
            Console.WriteLine(MitArr[t].ToString());

        Console.WriteLine("Gennemløb af array med foreach-løkken");

        foreach (int Vaerdi in MitArr)
            Console.WriteLine(Vaerdi);
    }
}