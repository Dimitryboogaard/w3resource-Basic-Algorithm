using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _83
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;

            lblAntwoord.Text = "";

            if (strTekst.Length < 2)
            {
                for (intTeller = 1; intTeller <= 3; intTeller++)
                {
                    lblAntwoord.Text += strTekst;
                }
            }

            else
            {
                for(intTeller = 1; intTeller <= 3; intTeller++)
                {
                    lblAntwoord.Text += strTekst.Substring(0, 2);
                }
            }
        }
    }
}
