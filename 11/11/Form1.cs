using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intStringLengte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intStringLengte = strTekst.Length;

            lblAntwoord.Text = intStringLengte < 3 ? strTekst.Substring(0, intStringLengte) +
                               strTekst + strTekst.Substring(0, intStringLengte) :
                               strTekst.Substring(0, 3) +
                               strTekst + strTekst.Substring(0, 3);
        }
    }
}
