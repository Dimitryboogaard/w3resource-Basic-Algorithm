using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intStringLengte, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intStringLengte = strTekst.Length;
            lblAntwoord.Text = "";

            for(intTeller = 0; intTeller < intStringLengte; intTeller += 4)
            {
                lblAntwoord.Text += strTekst.Substring(intTeller, 1) + strTekst.Substring(intTeller + 1, 1);
            }
        }
    }
}
