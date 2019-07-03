using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _94
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 10, 20, -30, -40 };
        int intMax, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intMax = arrayGetallen.Max();

            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                arrayGetallen[intTeller] = intMax;
            }

            lblAntwoord.Text = "";

            foreach(int Getal in arrayGetallen)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
