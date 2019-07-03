using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 5, 5, 2 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 5, 5, 2, 5, 5 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 5, 6, 2, 9 });
        }

        public static int test(int[] arrayGetallen)
        {
            var intDubbel5Teller = 0;

            for (int intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {

                if(arrayGetallen[intTeller] == 5 && arrayGetallen[intTeller + 1] == 5 ||
                    arrayGetallen[intTeller + 1] == 6)
                {

                    intDubbel5Teller++;
                }
            }

            return intDubbel5Teller;
        }
    }
}
