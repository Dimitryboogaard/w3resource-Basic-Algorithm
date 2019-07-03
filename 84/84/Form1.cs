using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _84
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

            if (strTekst.Length > 1)
            {
                if (strTekst.Substring(0, 2) == strTekst.Substring(strTekst.Length - 2))
                {
                    lblAntwoord.Text = strTekst.Substring(2);
                }

                else
                    lblAntwoord.Text = strTekst;
            }
            else
                tbTekst.Text = "";
        }
    }
}
