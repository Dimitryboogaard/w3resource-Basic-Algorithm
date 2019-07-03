using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _89
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 10, 20, 40, 50 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 10, 20, 40, 10 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 12, 24, 35, 55 }) + Environment.NewLine;

        }

        public static bool test(int[] arrayGetallen)
        {
            return arrayGetallen[0] == arrayGetallen[arrayGetallen.Length - 1];
        }
    }
}
