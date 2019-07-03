using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 5, 7, 9, 11, 13 };
        int[] arrayNieuw = new int[3];
        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {

            for(intTeller = 0; intTeller < 3; intTeller++)
            {
                arrayNieuw[intTeller] = arrayGetallen[arrayGetallen.Length / 2 - 1 + intTeller];
            }

            lblAntwoord.Text = "";

            foreach (int Getal in arrayNieuw)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }

        }
    }
}
