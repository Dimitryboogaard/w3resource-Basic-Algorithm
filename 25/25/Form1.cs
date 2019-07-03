using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intAantal, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intAantal = Convert.ToInt32(tbAantal.Text);
            if (intAantal < 0)
            {
                tbAantal.Text = "";

            }

            else
            {
                lblAntwoord.Text = "";

                for (intTeller = 1; intTeller <= intAantal; intTeller++)
                {
                    lblAntwoord.Text += strTekst;
                }
            }
        }
    }
}
