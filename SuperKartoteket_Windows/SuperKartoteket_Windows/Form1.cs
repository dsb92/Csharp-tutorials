using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kundekartotek;

namespace SuperKartoteket_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum eKundeoperation { Ny, Rediger };
        private eKundeoperation MinKundeoperation;
        private CKundekartotek kk;
        
        private void btnNy_Click(object sender, EventArgs e) 

        {
            //Tillad kun indtastning i kundepanel
            grpKunde.Enabled = true;
            grpKundeoversigt.Enabled = false;

            //Rens kundefelter
            txtNavn.Text = "";
            txtAdr.Text = "";
            txtTlf.Text = "";

            txtNavn.Focus();

            MinKundeoperation = eKundeoperation.Ny;
        }

        private void btnRediger_Click(object sender, EventArgs e)
        {
            //Tillad kun indtastning i kundepanel
            grpKunde.Enabled = true;
            grpKundeoversigt.Enabled = false;

            txtNavn.Text = "";
            txtAdr.Text = "";
            txtTlf.Text = "";

            txtNavn.Focus();

            MinKundeoperation = eKundeoperation.Rediger;
        }

        private void btnSlet_Click(object sender, EventArgs e)
        {
            try
            {
                string strID = lstKundeoversigt.FocusedItem.Text;
                kk.SletKunde(Convert.ToInt32(strID, 10));

                OpdaterOversigt();
            }
            catch (NullReferenceException f)
            {
                Console.Error.WriteLine(f.Message);
            }


        }

        private void btnOK_Click(object sender, EventArgs e) 
        {
            try
            {
                if (MinKundeoperation == eKundeoperation.Ny)
                    kk.NyKunde(txtNavn.Text, txtAdr.Text, txtTlf.Text);
                else//Rediger
                {
                    string strID = lstKundeoversigt.FocusedItem.Text;
                    kk.OpdaterKunde(Convert.ToInt32(strID, 10), txtNavn.Text, txtAdr.Text, txtTlf.Text);
                }
            }
            catch (NullReferenceException f)
            {
                Console.Error.WriteLine(f.Message);
            }

                OpdaterOversigt();

                //Tillad ej indtastning i kundepanel
                grpKunde.Enabled = false;
                grpKundeoversigt.Enabled = true;
       
        }

        private void btnAnnuller_Click(object sender, EventArgs e)
        {
            //Tillad ej indtastning i kundepanel
            grpKunde.Enabled = false;
            grpKundeoversigt.Enabled = true;
        }

        //Opdater listview'en med kundedata
        void OpdaterOversigt()
        {
            try
            {

                CKunde MinKunde;

                lstKundeoversigt.Items.Clear();

                MinKunde = kk.FoersteKunde();
                while (MinKunde != null) // Sålængde der er kunder
                {
                    ListViewItem MinRaekke =
                        IndsaetKunde(MinKunde.ID.ToString(), MinKunde.Navn, MinKunde.Adr, MinKunde.Tlf);

                    //Indsæt i listview
                    lstKundeoversigt.Items.Add(MinRaekke);

                    MinKunde = kk.NaesteKunde();
                }

                if (lstKundeoversigt.Items.Count == 0)
                {
                    btnRediger.Enabled = false;
                    btnSlet.Enabled = false;
                }
                else
                {
                    btnRediger.Enabled = true;
                    btnSlet.Enabled = true;
                }
            }
            catch (NullReferenceException f)
            {
                Console.Error.WriteLine(f.Message);
            }
        }

        //Returner en ListViewItem med hver enkelt kunde til OpdaterOversigt
        ListViewItem IndsaetKunde(string ID, string Navn, string Adr, string Tlf)
        {
            ListViewItem MinRaekke = new ListViewItem();
            MinRaekke.Text = ID;
            MinRaekke.SubItems.Add(Navn);
            MinRaekke.SubItems.Add(Adr);
            MinRaekke.SubItems.Add(Tlf);
            return MinRaekke;
        }

        private void grpKundeoversigt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstKundeoversigt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
                    

    }
}
