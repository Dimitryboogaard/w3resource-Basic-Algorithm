using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            
            rtUitvoer.Text += test(new[] { 1, 5, 6, 9, 10, 17 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 5, 5, 5, 10, 17 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 1, 5, 5, 5, 5 }) + Environment.NewLine;

        }

        static bool test(int[] arrayGetallen)
        {
            int intSom = 0;

            foreach(int Getal in arrayGetallen)
            {
                if (Getal == 5)
                    intSom += 5;
            }

            return intSom == 15;
        }
    }
}
