using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _92
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 10, 20, -30, -40 };
        int intTijdelijk, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intTijdelijk = arrayGetallen[0];

            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                arrayGetallen[intTeller] = arrayGetallen[intTeller + 1];
            }

            arrayGetallen[arrayGetallen.Length - 1] = intTijdelijk;

            lblAntwoord.Text = "";

            foreach(int Getal in arrayGetallen)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
