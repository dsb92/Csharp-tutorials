using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kundekartotek;

namespace SuperKartoteket
{
    class CSuperkartoteket
    {
        static void Main(string[] args)
        {
            //Lav ny instans af Kundekartoteket
            CKundekartotek kk = new CKundekartotek();

            bool bAfslut = false;
            string Navn, Adr, Tlf, strID;
            int ID;

            do
            {
                //Vis menu
                Console.WriteLine("\n*** Menu ***");
                Console.WriteLine("1) Opret kunde");
                Console.WriteLine("2) Opret Kundedata");
                Console.WriteLine("3) Slet Kunde");
                Console.WriteLine("4) Vis Kundeliste");
                Console.WriteLine("a) Afslut");

                //Aflæs menuvalg
                Console.Write("Valg : ");
                string valg = Console.ReadLine();

                //Indsæt linieskift mellem valg og operation
                Console.WriteLine("\n");

                try
                {
                    switch (valg)
                    {
                        case "1": //Opret ny kunde
                            Console.WriteLine("--> Opretter kunde");
                            Console.WriteLine("Navn: ");
                            Navn = Console.ReadLine();
                            Console.Write("Adr : ");
                            Adr = Console.ReadLine();
                            Console.Write("Tlf : ");
                            Tlf = Console.ReadLine();
                            kk.NyKunde(Navn, Adr, Tlf);
                            break;
                        case "2": // Opdater kundedata
                            Console.WriteLine("--> Opdaterer kundedata");
                            Console.Write("ID på kunde som skal opdateres: ");
                            strID = Console.ReadLine();
                            ID = Convert.ToInt32(strID, 10);
                            Console.Write("Navn : ");
                            Navn = Console.ReadLine();
                            Console.Write("Adr : ");
                            Adr = Console.ReadLine();
                            Console.Write("Tlf : ");
                            Tlf = Console.ReadLine();
                            kk.OpdaterKunde(ID, Navn, Adr, Tlf);
                            break;
                        case "3":// Slet kunde
                            Console.WriteLine("--> Sletter kunde");
                            Console.Write("ID på kunde som skal slettes: ");
                            strID = Console.ReadLine();
                            ID = Convert.ToInt32(strID, 10); //Konverter streng til int
                            kk.SletKunde(ID);
                            break;
                        case "4": //Vis kunder
                            Console.WriteLine("--> Viser kunder");
                            Console.WriteLine("{0,-5}{1,-25}{2,-35}{3,-8}", "ID", "Navn", "Adr", "Tlf");
                            CKunde MinKunde;

                            MinKunde = kk.FoersteKunde();
                            while (MinKunde != null) // Så længe der er kunder
                            {
                                Console.WriteLine("{0,-5}{1,-25}{2,-35}{3,-8}", MinKunde.ID, MinKunde.Navn, MinKunde.Adr, MinKunde.Tlf);

                                MinKunde = kk.NaesteKunde();
                            }
                            break;

                        case "a": //Afslut
                            bAfslut = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            } while (bAfslut == false); //Indtil der valgt afslut i menuen
        }
    }
}












