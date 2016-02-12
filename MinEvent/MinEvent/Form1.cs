using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinEvent
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEventEnhed MinEventEnhed = new CEventEnhed();

            MinEventEnhed.eh += new MinEventHandler(MinEvent);
            MinEventEnhed.Aktiver();
        }

        public static void MinEvent(string str)
        {
            MessageBox.Show(str);
        }
    }

    public delegate void MinEventHandler(string str);

    class CEventEnhed
    {
        public event MinEventHandler eh;

        public void Aktiver()
        {
            if (eh == null)
                return;

            eh("Event er aktiveret!");
        }
    }

}
