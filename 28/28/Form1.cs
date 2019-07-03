using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intTeller, intStringLengte, intEersteATeller;
        bool booAa = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intStringLengte = strTekst.Length;

            for(intTeller = 0; intTeller <= intStringLengte - 2; intTeller++)
            {
                if(strTekst.Substring(intTeller ,1) == "a")
                {
                    intEersteATeller++;
                }
                if(strTekst.Substring(intTeller, 1) == "a" && strTekst.Substring(intTeller + 1, 1) == "a"
                    && intEersteATeller < 2)
                {
                    booAa = true;
                }
            }

            lblAntwoord.Text = booAa.ToString();

            booAa = false;
            intEersteATeller = 0;
        }
    }
}
