using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _93
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arraGetallen = new[] { 10, 20, -30, -40, 50 };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            Array.Reverse(arraGetallen);

            lblAntwoord.Text = "";

            foreach(int Getal in arraGetallen)
            {
                lblAntwoord.Text += Getal.ToString() + " ";
            }
        }
    }
}
