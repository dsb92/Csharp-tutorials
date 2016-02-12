using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckService_Click(object sender, EventArgs e)
        {
            ServiceControllerStatus MinStatus; //Enum

            serviceController1.DisplayName = txtService.Text;
            MinStatus = serviceController1.Status;

            switch (MinStatus)
            {
                case ServiceControllerStatus.Running: MessageBox.Show("Kører!");
                    break;
                case ServiceControllerStatus.Stopped: MessageBox.Show("Stoppet");
                    break;
                default: MessageBox.Show("Servicen er hverken startet eller stoppet!");
                    break;
            }
        }
    }
}
