using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 5, 7, 9, 10, 12 };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = Convert.ToString(arrayGetallen.Max() - arrayGetallen.Min());
        }
    }
}
