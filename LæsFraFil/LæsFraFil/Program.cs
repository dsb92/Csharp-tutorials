using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//In-strømmen: Læse input fra tastaturet og skrive til filen ind.txt
// Out-strømmen: Åbne en fil og sætte den til at pege mod Out-strømmen: Ændre filtilgangen i linie 7 til
// FileAccess.Write. Linie 10 udskifter du med Console.SetOut(sr).

namespace LæsFraFil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Åbn filen ind.txt
            FileStream fs = new FileStream("ind.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            //Ændr inputstrømmen til filen ind.txt
            Console.SetIn(sr);

            //Udskriv filens indhold
            string strLinie;
            while((strLinie = sr.ReadLine())!=null)
            Console.WriteLine(strLinie);

            //HUsk at lukke strømmen og filen
            sr.Close();
            fs.Close();
        }
    }
}
