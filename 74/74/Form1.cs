using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _74
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intIndex;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intIndex = int.Parse(tbIndex.Text);

            lblAntwoord.Text = intIndex + 2 <= strTekst.Length ?
                               strTekst.Substring(intIndex, 2) : strTekst.Substring(0, 2);
        }
    }
}
