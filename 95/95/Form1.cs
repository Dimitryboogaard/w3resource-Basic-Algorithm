using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _95
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen1 = new[] { 10, 20, -30, -40, 30 };
        int[] arrayGetallen2 = new[] { 10, 20, 30, 40, 30 };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = arrayGetallen1[2].ToString() + " " + arrayGetallen2[2].ToString();
        }
    }
}
