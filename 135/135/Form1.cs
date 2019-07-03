using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _135
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 1, 2, 3, 4, 6, 8 }) + "\n";
            rtUitvoer.Text += test(new[] { 15, 2, 3, 4, 15, 11 }) + "\n";
        }

        static int test(int[] arrayGetallen)
        {
            int intGem1 = 0;
            int intAantal = 0;
            int intGem2 = 0;
            int intTeller = 0;

            for(intTeller = 0; intTeller < arrayGetallen.Length / 2; intTeller++)
            {
                intGem1 += arrayGetallen[intTeller];
                intAantal++;
            }

            intGem1 = intGem1 / intAantal;

            intAantal = 0;

            for (intTeller = arrayGetallen.Length / 2; intTeller < arrayGetallen.Length; intTeller++)
            {
                intGem2 += arrayGetallen[intTeller];
                intAantal++;
            }

            intGem2 = intGem2 / intAantal;

            return Math.Max(intGem1, intGem2);

        }
    }
}
