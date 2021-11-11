using ServiceMtk_P1_20190140044;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ServerConfigForm_P5_044
{
    public partial class Form1 : Form
    {
        private ServiceHost hostObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            hostObj = new ServiceHost(typeof(Matematika));

            labelOnorOff.Text = "Server :  ON ";
            labelKet.Text = "Klik 'OFF' untuk mematikan Server";
            hostObj.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;

        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            labelOnorOff.Text = "Server :  OFF ";
            labelKet.Text = "Klik 'ON' untuk menjalankan Server";
            hostObj.Close();
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
        }
    }
}
