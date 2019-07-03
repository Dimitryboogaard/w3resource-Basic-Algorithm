using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intAantal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intAantal = int.Parse(tbAantal.Text);

            if(strTekst.Length >= intAantal)
            {
                lblAntwoord.Text = strTekst.Substring(0, intAantal) +
                                   strTekst.Substring(strTekst.Length - intAantal);
            }
        }
    }
}
