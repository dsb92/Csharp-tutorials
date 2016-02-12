using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ReflectionParam
{
    class CReflectionParam
    {
        static void Main(string[] args)
        {
            ReflMetode("Hej fra Main", 16);
        }

        public static void ReflMetode(string MinStr, int MinInt)
        {
            //Vores bro til Reflection API'et
            Type MinType = typeof(CReflectionParam);

            //Hent liste over alle metoder for klassen
            MethodInfo[] MinMI = MinType.GetMethods();
            foreach (MethodInfo mi in MinMI)
                if (mi.Name == "ReflMetode") //Kun interesseret i denne metode
                {
                    ParameterInfo[] MinPI = mi.GetParameters(); //Hent param. for metoden
                    foreach (ParameterInfo pi in MinPI)
                    {
                        Console.WriteLine("Parameterinfo : Navn = {0}, Type = {1}", pi.Name, pi.ParameterType.ToString());
                    }
                }
        }


    }
}
