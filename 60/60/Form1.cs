using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst1, strTekst2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst1 = tbTekst1.Text;
            strTekst2 = tbTekst2.Text;

            lblAntwoord.Text = strTekst1 + strTekst2 + strTekst2 + strTekst1;
        }
    }
}
