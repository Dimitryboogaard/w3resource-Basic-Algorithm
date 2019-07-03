using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += Test(new[] { 3, 5, 1, 3, 7 }) + "\n";
            rtUitvoer.Text += Test(new[] { 1, 2, 3, 4 }) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 3, 5, 5, 5, 5 }) + "\n";
            rtUitvoer.Text += Test(new[] { 2, 4, 5, 6 }) + "\n";

        }

        static bool Test(int[] arrayGetallen)
        {
            int intTeller = 0;

            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                if(arrayGetallen[intTeller] % 2 == 0 && arrayGetallen[intTeller + 1] % 2 == 0 ||
                    arrayGetallen[intTeller] % 2 != 0 && arrayGetallen[intTeller + 1] % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
