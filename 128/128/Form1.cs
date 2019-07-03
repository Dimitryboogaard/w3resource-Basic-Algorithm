using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _128
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 2, 3, 5, 7 };
        int intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if (arrayGetallen[intTeller] != 5)
                {
                    lblAntwoord.Text += arrayGetallen[intTeller].ToString() + " ";
                }

                else
                    break;
            }
        }
    }
}
