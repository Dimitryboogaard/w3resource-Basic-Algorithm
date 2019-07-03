using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2, intGetal3;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = int.Parse(tbGetal1.Text);
            intGetal2 = int.Parse(tbGetal2.Text);
            intGetal3 = int.Parse(tbGetal3.Text);

            lblAntwoord.Text = Convert.ToString(intGetal1 == 20 || intGetal2 == 20 || intGetal3 == 20 ||
                               intGetal1 < intGetal2 && intGetal1 < intGetal3 ||
                               intGetal2 < intGetal1 && intGetal2 < intGetal3 ||
                               intGetal3 < intGetal1 && intGetal3 < intGetal2);
        }
    }
}
