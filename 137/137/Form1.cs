using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _137
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            string[] nieuweArray = test(new[] { "a", "b", "bb", "c", "ccc" }, 3);

            foreach(string String in nieuweArray)
            {
                lblAntwoord.Text += String + " ";
            }
        }

        static string[] test(string[] arrayStrings, int Lengte)
        {
            string[] arrayNieuw = new string[Lengte];
            int intTeller = 0;

            for(intTeller = 0; intTeller < Lengte; intTeller++)
            {
                arrayNieuw[intTeller] = arrayStrings[intTeller];
            }

            return arrayNieuw;
        }
    }
}
