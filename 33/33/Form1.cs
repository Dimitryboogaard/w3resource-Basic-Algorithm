using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 1, 2, 9, 3 }, 3) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 3, 4, 5, 6 }, 2) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 2, 3 }, 9);
        }

        private static bool test(int[] arrayGetallen, int intGetal)
        {
            return arrayGetallen.Length < 4 ? arrayGetallen.Contains(intGetal) : 
                   arrayGetallen.Take(4).Contains(intGetal);
        }
    }
}
