using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _99
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 10, 20, -30, -40, 30 };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            int[] arrayNieuw = new int[arrayGetallen.Length * 2];

            arrayNieuw[0] = arrayGetallen[0];

            lblAntwoord.Text = "";

            foreach(int Getal in arrayNieuw)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
