using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2;
        const int cint30 = 30;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt32(tbGetal1.Text);
            intGetal2 = Convert.ToInt32(tbGetal2.Text);

            lblAntwoord.Text = Convert.ToString(Test(intGetal1, intGetal2));
        }

        public static bool Test(int x, int y)
        {
            return x + y == cint30 || (x == cint30 ^ y == cint30);
        }

    }
}
