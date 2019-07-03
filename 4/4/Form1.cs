using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
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

            lblAntwoord.Text = Convert.ToString(Math.Abs(intGetal - 100) <= 10 ||
                               Math.Abs(intGetal - 200) <= 10);
        }
    }
}
