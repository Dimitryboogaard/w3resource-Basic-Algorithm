using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _109
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 5, 7, 9, 10, 12 };
        int intEvenTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            foreach (int Getal in arrayGetallen)
            {
                if(Getal % 2 == 0)
                {
                    intEvenTeller++;
                }
            }

            lblAntwoord.Text = intEvenTeller.ToString();
        }
    }
}
