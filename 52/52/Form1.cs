using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52
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

            lblAntwoord.Text = Convert.ToString(intGetal1 == intGetal2 ? 0 : intGetal1 % 7 == intGetal2 % 7 ? 
                               Math.Min(intGetal1, intGetal2) :
                               Math.Max(intGetal1, intGetal2));
        }
    }
}
