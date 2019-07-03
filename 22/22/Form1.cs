using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intStringLengte, intTeller, intZTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intStringLengte = strTekst.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strTekst.Substring(intTeller, 1) == "z")
                {
                    intZTeller++;
                }
            }

            lblAntwoord.Text = Convert.ToString(intZTeller > 1 && intZTeller < 4);
            intZTeller = 0;
        }
    }
}
