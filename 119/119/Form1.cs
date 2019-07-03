using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _119
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += Test(new[] { 5, 5, 5, 5, 5 }) + "\n";
            rtUitvoer.Text += Test(new[] { 1, 2, 3, 4 }) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 3, 5, 5, 5, 5 }) + "\n";
            rtUitvoer.Text += Test(new[] { 1, 5, 5, 7, 8, 10 }) + "\n";

        }

        static bool Test(int[] arrayGetallen)
        {
            int intTeller = 0;
            bool boo35 = false;

            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                if (arrayGetallen[intTeller] == 3 && arrayGetallen[intTeller + 1] == 3 ||
                   arrayGetallen[intTeller] == 5 && arrayGetallen[intTeller + 1] == 5)
                    boo35 = true;
            }

            return boo35;
        }
    }
}
