using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen1 = new[] { 10, 20, -30 };
        int[] arrayGetallen2 = new[] { 10, 20, 30 };
        int intSomArray1, intSomArray2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            foreach(int Getal in arrayGetallen1)
            {
                intSomArray1 += Getal;
            }

            foreach(int Getal in arrayGetallen2)
            {
                intSomArray2 += Getal;
            }

            lblAntwoord.Text = intSomArray1 > intSomArray2 ? "Array 1 is groter: " + intSomArray1.ToString() :
                               intSomArray2 > intSomArray1 ? "Array 2 is groter: " + intSomArray2.ToString() :
                               "Beiden even groot: " + intSomArray1.ToString();
        }
    }
}
