using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _79
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

            lblAntwoord.Text = strTekst.Length < 2 ? strTekst : strTekst.Substring(0, strTekst.Length - 2) +
                               strTekst.Substring(strTekst.Length - 1, 1) +
                               strTekst.Substring(strTekst.Length - 2, 1);
        }
    }
}
