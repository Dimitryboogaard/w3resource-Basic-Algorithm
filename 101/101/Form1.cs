using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 5, 7 };
        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                if(arrayGetallen[intTeller] == 5 && arrayGetallen[intTeller + 1] == 7)
                {
                    arrayGetallen[intTeller + 1] = 1;
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
