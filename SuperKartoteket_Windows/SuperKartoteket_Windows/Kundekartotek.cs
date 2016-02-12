using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Kundekartotek
{
    public class CPerson
    {
        //Constructor

        public CPerson(string Navn, string Adr, string Tlf)
        {
            navn = Navn;
            adr = Adr;
            tlf = Tlf;
        }

        //Opdater: Virtual metode (overrides i Ckunde), som opdaterer kundedata
        virtual public void Opdater(string Navn, string Adr, string Tlf)  //virtual skal tilføjes, hvis denne metode senere henne skal overrides(overskrives), medmindre metoden var abstract (implicit virtual) 
        {
            navn = Navn;
            adr = Adr;
            tlf = Tlf;
        }

        //Property : navn
        protected string navn;
        public string Navn
        {
            get
            {
                return navn;
            }
        }

        //Property : adr
        protected string adr;
        public string Adr
        {
            get
            {
                return adr;
            }
        }
        //Property : tlf
        protected string tlf;
        public string Tlf
        {
            get
            {
                return tlf;
            }
        }

    } //CPerson klassen færdig. 

    public class CKunde : CPerson  //CKunde klassen arver fra klassen CPerson
    {
        private static int KundeID = 0;

        //Constructor
        public CKunde(string Navn, string Adr, string Tlf)
            : base(Navn, Adr, Tlf) // Superklassen(CPerson)'s data. 
        {
            iD = KundeID++;
        }

        //Opdater: Overrideet metode, som opdaterer kundedata
        public override void Opdater(string Navn, string Adr, string Tlf)
        {
            base.Opdater(Navn, Adr, Tlf);
        }
        //Property : ID
        private int iD;
        public int ID
        {
            get { return iD; }
        }

    } //CKunde klassen færdig

    public class CKundekartotek
    {
        //Constructor
        public CKundekartotek()
        {
            arrKunder = new ArrayList();
            KundePegepind = 0;
        }

        //NyKunde : Opret ny kunde
        public void NyKunde(string Navn, string Adr, string Tlf)
        {
            try
            {
                CKunde MinKunde = new CKunde(Navn, Adr, Tlf);
                arrKunder.Add(MinKunde);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //OpdaterKunde : Opdater kundens stamdata
        public void OpdaterKunde(int ID, string Navn, string Adr, string Tlf)
        {
            try
            {
                CKunde MinKunde = FindKunde(ID);
                MinKunde.Opdater(Navn, Adr, Tlf);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //SletKunde : Sletter en kunde
        public void SletKunde(int ID)
        {
            try
            {
                CKunde MinKunde;
                MinKunde = FindKunde(ID);

                arrKunder.Remove(MinKunde);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //FindKunde : Find en kunde baseret på kundeid
        private CKunde FindKunde(int ID)
        {
            bool bStopIteration = false;
            CKunde MinKunde = null;

            IEnumerator MinEnumerator = arrKunder.GetEnumerator();
            while (MinEnumerator.MoveNext() && bStopIteration == false)
            {
                MinKunde = (CKunde)MinEnumerator.Current;
                if (MinKunde.ID == ID)
                    bStopIteration = true;
            }

            if (bStopIteration == true)
                return MinKunde;
            else
                throw new CKartoteksException("Kunde ej fundet!");
        }

        private int KundePegepind;

        //Førstkunde: Sæt pegepind til første kunde, og returner denne
        public CKunde FoersteKunde()
        {
            KundePegepind = 0;
            if (arrKunder.Count == 0)
                return null;
            else
                return ((CKunde)arrKunder[KundePegepind]);
        }

        //NaesteKunde : Sæt pegepind til næste kunde, og retuner denne
        public CKunde NaesteKunde()
        {
            ++KundePegepind;
            if (KundePegepind >= arrKunder.Count)
            {
                --KundePegepind;
                return null;
            }
            return ((CKunde)arrKunder[KundePegepind]);
        }

        //Array af kunder
        private ArrayList arrKunder;
    } //CKundekartotek klassen færdig. 

    public class CKartoteksException : ApplicationException
    {
        public CKartoteksException() : base() { }
        public CKartoteksException(string message) : base(message) { }
        public CKartoteksException(string message, Exception inner) :
            base(message, inner) { }
    }


}

//Dvs. følgende klasser: CPerson, CKunde, CKundekartotek, CKaroteksException (oprettelse af egen exception klasse) 