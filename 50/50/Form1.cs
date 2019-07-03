using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strGetal1, strGetal2, strGetal3;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strGetal1 = tbGetal1.Text;
            strGetal2 = tbGetal2.Text;
            strGetal3 = tbGetal3.Text;

            
            lblAntwoord.Text = Convert.ToString(strGetal1.Substring(strGetal1.Length - 1) == strGetal2.Substring(strGetal2.Length - 1) ||
                               strGetal1.Substring(strGetal1.Length - 1) == strGetal3.Substring(strGetal3.Length - 1) ||
                               strGetal2.Substring(strGetal2.Length - 1) == strGetal3.Substring(strGetal3.Length - 1));
            

        }
    }
}
