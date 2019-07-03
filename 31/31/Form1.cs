using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst, strLaatste2Karakters;
        int intStringLengte, intTeller, intStringTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intStringLengte = strTekst.Length;

            strLaatste2Karakters = strTekst.Substring(intStringLengte - 2);

            for(intTeller = 0; intTeller < intStringLengte - 2; intTeller++)
            {
                if(strLaatste2Karakters == strTekst.Substring(intTeller, 2))
                {
                    intStringTeller++;
                }
            }

            lblAntwoord.Text = intStringTeller.ToString();
            intStringTeller = 0;
        }
    }
}
