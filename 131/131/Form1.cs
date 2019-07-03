using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 2, 5, 3, 5, 7, 5, 9, 11 };
        int intTeller, intTeller2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if(arrayGetallen[intTeller] == 5)
                {
                    for(intTeller2 = intTeller; intTeller2 < arrayGetallen.Length - 1; intTeller2++)
                    {
                        arrayGetallen[intTeller2] = arrayGetallen[intTeller2 + 1];
                    }

                    arrayGetallen[arrayGetallen.Length - 1] = 0;
                }
            }

            lblAntwoord.Text = "";

            foreach(int Getal in arrayGetallen)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
