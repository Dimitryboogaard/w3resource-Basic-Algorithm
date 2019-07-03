using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 10, 22, 35, 47, 53, 67 };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            foreach(int Getal in arrayGetallen)
            {
                if (Getal % 10 != 7)
                    lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
