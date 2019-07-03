using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal = Convert.ToInt32(tbGetal.Text);

            if (intGetal < 0)
                tbGetal.Text = "";
            else
                lblAntwoord.Text = Convert.ToString((intGetal % 3 == 0) ^ (intGetal % 7 == 0));
        }
    }
}
