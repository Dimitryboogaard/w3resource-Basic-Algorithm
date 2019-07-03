using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _145
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 2, 3, 4 };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            foreach(int Getal in arrayGetallen)
            {
                lblAntwoord.Text += Convert.ToString((Getal + 2) * 5) + " ";
            }
        }
    }
}
