using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += Test(new[] { 5, 5, 5, 5, 5 }) + Environment.NewLine;
            rtUitvoer.Text += Test(new[] { 3, 3, 3, 3 }) + Environment.NewLine;
            rtUitvoer.Text += Test(new[] { 3, 3, 3, 5, 5, 5 }) + Environment.NewLine;
            rtUitvoer.Text += Test(new[] { 1, 6, 8, 10 }) + Environment.NewLine;

        }

        static bool Test(int[] arrayGetallen)
        {
            bool boo3 = false, boo5 = false;

            foreach(int Getal in arrayGetallen)
            {
                if (Getal == 3)
                    boo3 = true;

                if (Getal == 5)
                    boo5 = true;
            }

            return boo3 || boo5;
        }
    }
}
