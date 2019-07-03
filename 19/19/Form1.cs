using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
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
            intGetal1 = Convert.ToInt32(tbGetal1.Text);
            intGetal2 = Convert.ToInt32(tbGetal2.Text);

            if(intGetal1 == intGetal2)
            {
                lblAntwoord.Text = "0";
            }
            else if(Math.Abs(100 - intGetal1) < Math.Abs(100 - intGetal2))
            {
                lblAntwoord.Text = intGetal1.ToString();

            }
            else
            {
                lblAntwoord.Text = intGetal2.ToString();

            }
        }
    }
}
