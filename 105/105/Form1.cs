using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _105
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 5, 7, 9, 11, 13 };
        int intTijdelijk;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intTijdelijk = arrayGetallen[0];
            arrayGetallen[0] = arrayGetallen[arrayGetallen.Length - 1];
            arrayGetallen[arrayGetallen.Length - 1] = intTijdelijk;

            lblAntwoord.Text = "";

            foreach(int Getal in arrayGetallen)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
