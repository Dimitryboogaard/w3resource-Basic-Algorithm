using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strGetal1, strGetal2;
        int intStringLengteGetal1, intStringLengteGetal2, intTeller, intTeller2;
        int intGetal1, intGetal2;
        bool booSameDigit = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strGetal1 = tbGetal1.Text;
            strGetal2 = tbGetal2.Text;
            intGetal1 = int.Parse(strGetal1);
            intGetal2 = int.Parse(strGetal2);
            intStringLengteGetal1 = strGetal1.Length;
            intStringLengteGetal2 = strGetal2.Length;

            if(intGetal1 >= 10 && intGetal1 <= 99 && intGetal2 >= 10 && intGetal2 <= 99)
            {
                for(intTeller = 0; intTeller < intStringLengteGetal1; intTeller++)
                {
                    for(intTeller2 = 0; intTeller2 < intStringLengteGetal2; intTeller2++)
                    {
                        if(strGetal1.Substring(intTeller, 1) == strGetal2.Substring(intTeller2, 1))
                        {
                            booSameDigit = true;
                        }
                    }
                }
            }

            lblAntwoord.Text = booSameDigit.ToString();
            booSameDigit = false;
        }
    }
}
