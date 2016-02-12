using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Reflection_Sinus
{
    class CReflection_Sinus
    {
        static void Main(string[] args)
        {
            //Hent type information
            Type MinType = Type.GetType("System.Math");
            //Lav instans
            Object MitObj = Activator.CreateInstance(MinType);

            //Metode er overdefineret, så fortæl her hvilken der skal bruge
            Type[] ParamType = new Type[1];
            //Vi bruger den overdefinerede version som tager parameteren Double
            ParamType[0] = Type.GetType("System.Double");

            //Hent metode oplysninger
            MethodInfo MinMetode = MinType.GetMethod("Sin", ParamType);

            //Forbered parameteren med teksen "Sen binding!"

            Object[] Param = new Object[1];
            Param[0] = 5;

            //Kald metoden WriteLine
            Object RetVal = MinMetode.Invoke(MitObj, Param);
            Console.WriteLine("Sinus af {0} er {1}", Param[0].ToString(), RetVal.ToString());


        }
    }
}
