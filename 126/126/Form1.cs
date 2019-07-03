using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 1, 2, 3, 5, 3, 7 }) + "\n";
            rtUitvoer.Text += test(new[] { 3, 7, 5, 5, 3, 7 }) + "\n";
            rtUitvoer.Text += test(new[] { 3, 7, 5, 5, 6, 7, 5 }) + "\n";

        }

        static bool test(int[] arrayGetallen)
        {
            int intTeller = 0;

            for(intTeller = 0; intTeller < arrayGetallen.Length - 2; intTeller++)
            {
                if(arrayGetallen[intTeller + 1] == arrayGetallen[intTeller] + 1 &&
                    arrayGetallen[intTeller + 2] == arrayGetallen[intTeller + 1] +1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
