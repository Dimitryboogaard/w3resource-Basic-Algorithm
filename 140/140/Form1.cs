using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 2, 3, 5, 7, 9, 10 };
        int intLengte = 3, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int[] arrayNieuw = new int[intLengte];

            foreach (int Getal in arrayGetallen)
            {
                if (Getal % 2 != 0 && intTeller < intLengte)
                {
                    arrayNieuw[intTeller] = Getal;
                    intTeller++;
                }

            }

            lblAntwoord.Text = "";

            foreach (int Getal in arrayNieuw)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
            
        }
    }
}
