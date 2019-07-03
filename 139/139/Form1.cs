using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(123) + "\n";
            rtUitvoer.Text += test(13) + "\n";
            rtUitvoer.Text += test(222) + "\n";

        }

        static bool test(int Getal)
        {
            while (Getal > 0)
            {
                if (Getal % 10 == 2)
                    return true;
                Getal /= 10;
            }

            return false;
        }
    }
}
