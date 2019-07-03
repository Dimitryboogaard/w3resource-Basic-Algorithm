using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += Test(new[] { 3, 7, 5, 5, 3, 7 }, 2) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 7, 5, 5, 3, 7 }, 3) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 7, 5, 5, 3, 7, 5 }, 3) + "\n";

        }

        static bool Test(int[] arrayGetallen, int Lengte)
        {
            int intTeller = 0;
            bool booWaarOfNiet = true;

            for(intTeller = 0; intTeller < Lengte; intTeller++)
            {
                if (arrayGetallen[intTeller] != arrayGetallen[arrayGetallen.Length - Lengte + intTeller])
                    booWaarOfNiet = false;
            }

            return booWaarOfNiet;
        }
    }
}
