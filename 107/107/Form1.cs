using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _107
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 1 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 9 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 9, 3, 3 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 3, 4, 5, 6, 7 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 }) + Environment.NewLine;

        }

        public int test(int[] arrayGetallen)
        {
            int intEerste, intMidden, intLaatste, intMax;

            intEerste = arrayGetallen[0];
            intMidden = arrayGetallen[arrayGetallen.Length / 2];
            intLaatste = arrayGetallen[arrayGetallen.Length - 1];
            intMax = intEerste;

            if (intMidden > intMax)
            {
                intMax = intMidden;
            }

            if (intLaatste > intMax)
            {
                intMax = intLaatste;
            }

            return intMax;
        }
    }
}
