using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Eksempel hvor udtrykkene try, catch og finally bliver vist.

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 0, c;
            try
            {
                c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Der blev divideret med 0.");
            }
            finally
            {
                Console.WriteLine("Alle exception handlers er blevet kørt.");
            }

        }
    }
}
