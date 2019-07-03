using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen1 = new[] { 10, 20, 30 };
        int[] arrayGetallen2 = new[] { 40, 50, 60 };
        int intTeller;
        

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int[] arrayNieuw = new int[arrayGetallen1.Length + arrayGetallen2.Length];

            for(intTeller = 0; intTeller < arrayGetallen1.Length; intTeller++)
            {
                arrayNieuw[intTeller] = arrayGetallen1[intTeller];
            }

            for(intTeller = 0; intTeller < arrayGetallen2.Length; intTeller++)
            {
                arrayNieuw[intTeller + arrayGetallen1.Length] = arrayGetallen2[intTeller];
            }

            lblAntwoord.Text = "";

            foreach(int Getal in arrayNieuw)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
