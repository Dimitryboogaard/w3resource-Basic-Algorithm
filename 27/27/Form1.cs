using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intAaTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strTekst = tbTekst.Text;
            int intStringLengte = strTekst.Length;

            for(int intTeller = 0; intTeller <= intStringLengte - 2; intTeller++)
            {
                if(strTekst.Substring(intTeller, 2) == "aa")
                {
                    intAaTeller++;
                }
            }

            lblAntwoord.Text = intAaTeller.ToString();
            intAaTeller = 0;
        }
    }
}
