using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _134
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 5, 5, 1, 15, 15 }) + "\n";
            rtUitvoer.Text += test(new[] { 15, 2, 3, 4, 15 }) + "\n";
            rtUitvoer.Text += test(new[] { 3, 3, 15, 15, 5, 5 }) + "\n";
            rtUitvoer.Text += test(new[] { 1, 5, 15, 7, 8, 15 }) + "\n";

        }

        static bool test(int[] arrayGetallen)
        {
            int intTeller = 0;

            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                if (arrayGetallen[intTeller] == arrayGetallen[intTeller + 1] && arrayGetallen[intTeller] == 15)
                    return true;
            }

            return false;
        }
    }
}
