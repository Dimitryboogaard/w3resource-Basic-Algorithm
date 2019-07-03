using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 10, 20, -30, -40, 30 };
        int[] arrayNieuw = new int[2];

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            arrayNieuw[0] = arrayGetallen[0];
            arrayNieuw[1] = arrayGetallen[arrayGetallen.Length - 1];

            lblAntwoord.Text = "";

            foreach(int Getal in arrayNieuw)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
