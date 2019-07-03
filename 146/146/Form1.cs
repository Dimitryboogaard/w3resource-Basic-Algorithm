using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _146
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 10, 22, 35, 41 };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            foreach(int Getal in arrayGetallen)
            {
                lblAntwoord.Text += Convert.ToString(Getal % 10) + " ";
            }
        }
    }
}
