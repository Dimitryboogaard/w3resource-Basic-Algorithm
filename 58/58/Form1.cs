using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = int.Parse(tbGetal1.Text);
            intGetal2 = int.Parse(tbGetal2.Text);

            lblAntwoord.Text = Convert.ToString(test(intGetal1, intGetal2));
        
        }

        private static int test(int Getal1, int Getal2)
        {
            if (Getal1 > 13 && Getal2 > 13) return 0;
            if (Getal1 <= 13 && Getal2 > 13) return Getal1;
            if (Getal1 > 13 && Getal2 <= 13) return Getal2;
            return Math.Max(Getal1, Getal2);

        }
    }
}
