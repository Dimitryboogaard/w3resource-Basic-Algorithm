using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _103
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 5, 7, 9, 11, 13 };
        int[] arrayNieuw = new int[2];

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            arrayNieuw[0] = arrayGetallen[arrayGetallen.Length / 2 - 1];
            arrayNieuw[1] = arrayGetallen[arrayGetallen.Length / 2];

            lblAntwoord.Text = arrayNieuw[0] + " " + arrayNieuw[1];
        }
    }
}
