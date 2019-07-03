using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intTeller, intStringLengte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intStringLengte = strTekst.Length;

            if(intStringLengte < 2)
            {
                lblAntwoord.Text = strTekst;
            }

            else
            {
                lblAntwoord.Text = "";

                for(intTeller = 1; intTeller <= 4; intTeller++)
                {
                    lblAntwoord.Text += strTekst.Substring(0, 2);
                }
            }
        }
    }
}
