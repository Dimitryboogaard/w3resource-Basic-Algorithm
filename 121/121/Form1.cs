using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _121
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
            rtUitvoer.Text += Test(new[] { 2, 5, 5, 7, 8, 10 }) + "\n";

        }

        static bool Test(int[] arrayGetallen)
        {
            bool boo3 = false;
            bool boo35 = false;

            foreach(int Getal in arrayGetallen)
            {
                if (Getal == 3)
                    boo3 = true;

                if (boo3 && Getal == 5)
                    boo35 = true;
            }

            return boo35;
        }
    }
}
