using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strGetal1, strGetal2;
        int intStringLengteGetal1, intStringLengteGetal2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strGetal1 = tbGetal1.Text;
            strGetal2 = tbGetal2.Text;
            intStringLengteGetal1 = strGetal1.Length;
            intStringLengteGetal2 = strGetal2.Length;

            lblAntwoord.Text = Convert.ToString((strGetal1.Substring(intStringLengteGetal1 - 1, 1) ==
               strGetal2.Substring(intStringLengteGetal2 - 1, 1)));
            

            
            
        }
    }
}
