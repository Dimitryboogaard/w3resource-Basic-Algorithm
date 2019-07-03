using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _90
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 50 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 10, 20, 40, 50 }, new[] { 10, 20, 40, 5 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 10, 20, 40, 50 }, new[] { 1, 20, 40, 5 }) + Environment.NewLine;

        }

        public static bool test(int[] arrayGetallen1, int[] arrayGetallen2)
        {
            return arrayGetallen1[0] == arrayGetallen2[0] ||
                   arrayGetallen1[arrayGetallen1.Length - 1] == arrayGetallen2[arrayGetallen2.Length - 1];
        }
    }
}
