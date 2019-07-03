using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 12, 20 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 20, 20 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 10, 10 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 10 }) + Environment.NewLine;

        }

        public static bool test(int[] arrayGetallen)
        {
            return arrayGetallen.Length == 2 && arrayGetallen[0] == 10 && arrayGetallen[1] == 10 ||
                   arrayGetallen[0] == 20 && arrayGetallen[1] == 20;
        }
    }
}
