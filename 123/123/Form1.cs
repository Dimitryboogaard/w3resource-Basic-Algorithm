using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += Test(new[] { 3, 5, 1, 5, 3, 5, 7, 5, 1, 5 }) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 5, 5, 5, 5, 5, 5 }) + "\n";
            rtUitvoer.Text += Test(new[] { 3, 5, 2, 5, 4, 5, 7, 5, 8, 5 }) + "\n";
            rtUitvoer.Text += Test(new[] { 2, 4, 5, 5, 5, 5 }) + "\n";

        }

        static bool Test(int[] arrayGetallen)
        {
            int intTeller = 0;
            int int5Teller = 0;
            bool boo5 = false;

            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if(arrayGetallen[intTeller] == 5 && boo5 == false)
                {
                    int5Teller++;
                    boo5 = true;
                }

                if (arrayGetallen[intTeller] != 5)
                {
                    boo5 = false;
                }
            }

            return int5Teller == 5;
        }
    }
}
