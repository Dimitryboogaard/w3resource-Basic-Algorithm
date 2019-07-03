using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
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

            if(intGetal1 >= 20 && intGetal1 <= 30 && intGetal2 >= 20 && intGetal2 <= 30)
            {
                lblAntwoord.Text = Convert.ToString(Math.Max(intGetal1, intGetal2));
            }

            else if(intGetal1 >= 20 && intGetal1 <= 30)
            {
                lblAntwoord.Text = intGetal1.ToString();
            }

            else if (intGetal2 >= 20 && intGetal2 <= 30)
            {
                lblAntwoord.Text = intGetal2.ToString();
            }

            else
            {
                lblAntwoord.Text = "0";

            }

        }
    }
}
