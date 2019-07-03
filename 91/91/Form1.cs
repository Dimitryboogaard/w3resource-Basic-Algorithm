using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _91
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen1 = new[] { 10, 20, 30, 40, 50 };
        int[] arrayGetallen2 = new[] { 10, 20, -30, -40, 50 };
        int intSomArray;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            foreach(int Getal in arrayGetallen1)
            {
                intSomArray += Getal;
            }
            lblAntwoord1.Text = intSomArray.ToString();

            intSomArray = 0;

            foreach (int Getal in arrayGetallen2)
            {
                intSomArray += Getal;
            }

            lblAntwoord2.Text = intSomArray.ToString();

        }

    }
}
