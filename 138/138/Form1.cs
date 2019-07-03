using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _138
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] arrayStrings = new[] { "a", "aaa", "b", "bbb", "c", "ccc" };
        int intLengte = 3, intStringTeller, intTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            foreach(string String in arrayStrings)
            {
                if (String.Length == intLengte)
                    intStringTeller++;
            }

            string[] arrayNieuw = new string[intStringTeller];

            intStringTeller = 0;

            foreach (string String in arrayStrings)
            {
                if (String.Length == intLengte)
                {
                    arrayNieuw[intStringTeller] = String;
                    intStringTeller++;
                }
            }

            lblAntwoord.Text = "";

            foreach(string String in arrayNieuw)
            {
                lblAntwoord.Text += String + " ";
            }
        }
    }
}
