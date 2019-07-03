using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 2, 5, 3, 5, 4, 6, 9, 11 };
        int intTeller, intIndex, intTijdelijk;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if(arrayGetallen[intTeller] % 2 == 0)
                {
                    intTijdelijk = arrayGetallen[intIndex];
                    arrayGetallen[intIndex] = arrayGetallen[intTeller];
                    arrayGetallen[intTeller] = intTijdelijk;
                    intIndex++;
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
