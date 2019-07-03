using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
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
            intGetal1 = Convert.ToInt16(tbGetal1.Text);
            intGetal2 = Convert.ToInt16(tbGetal2.Text);

            lblAntwoord.Text = Convert.ToString(test(intGetal1, intGetal2));

            
        }

        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
