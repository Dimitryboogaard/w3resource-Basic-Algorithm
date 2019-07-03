using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strTekst = tbTekst.Text;
            int intStringLengte = strTekst.Length;
            int intAantal = Convert.ToInt32(tbAantal.Text);

            if(intAantal < 0)
            {
                tbAantal.Text = "";
            }

            else
            {
                lblAntwoord.Text = "";

                for(int intTeller = 1; intTeller <= intAantal; intTeller++)
                {
                    lblAntwoord.Text += (intStringLengte < 3) ? strTekst : strTekst.Substring(0, 3);
                }
            }
        }
    }
}
