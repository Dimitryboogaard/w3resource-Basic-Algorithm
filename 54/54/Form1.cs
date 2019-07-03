using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _54
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2;
        string strGetal1, strSom;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = int.Parse(tbGetal1.Text);
            intGetal2 = int.Parse(tbGetal2.Text);

            if(intGetal1 >= 0 && intGetal2 >= 0)
            {
                strSom = Convert.ToString(intGetal1 + intGetal2);
                strGetal1 = intGetal1.ToString();

                lblAntwoord.Text = strSom.Length == strGetal1.Length ? strSom : strGetal1;
            }
        }
    }
}
