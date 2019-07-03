using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _85
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;

            if (strTekst.StartsWith("py"))
            {
                lblAntwoord.Text = strTekst;
            }

            else if (strTekst.Substring(0, 1) == "p")
            {
                lblAntwoord.Text = strTekst.Remove(1, 1);
            }

            else if (strTekst.Substring(1, 1) == "y")
                lblAntwoord.Text = strTekst.Remove(0, 1);

            else
                lblAntwoord.Text = strTekst.Substring(2);
        }
    }
}
