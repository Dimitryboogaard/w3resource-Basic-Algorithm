using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _130
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 2, 0, 3, 5, 7, 0, 9, 11 };
        int intTeller, intTeller2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if(arrayGetallen[intTeller] == 0)
                {
                    for(intTeller2 = intTeller; intTeller2 > 0; intTeller2--)
                    {
                        arrayGetallen[intTeller2] = arrayGetallen[intTeller2 - 1]; 
                    }

                    arrayGetallen[0] = 0;
                }
            }

            foreach(int Getal in arrayGetallen)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
