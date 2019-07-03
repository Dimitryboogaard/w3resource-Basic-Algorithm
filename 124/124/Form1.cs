using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += Test(new[] { 3, 5, 5, 3, 7 }) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 5, 5, 4, 1, 5, 7 }) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 5, 5, 5, 5, 5 }) + "\n";
            rtUitvoer.Text += Test(new[] { 2, 4, 5, 5, 6, 7, 5 }) + "\n";

        }

        public bool Test(int[] arrayGetallen)
        {
            int intTeller = 0;
            bool boo55 = false;

            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if (intTeller > 0 && arrayGetallen[intTeller] == 5 && arrayGetallen[intTeller - 1] == 5)
                {
                    boo55 = true;
                }

                else if (intTeller > 0 && arrayGetallen[intTeller] == 5 && arrayGetallen[intTeller - 1] != 5)
                    boo55 = false;
               
            }

            return boo55;
        }
    }
}
