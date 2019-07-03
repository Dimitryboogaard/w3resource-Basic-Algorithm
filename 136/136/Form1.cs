using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _136
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = Convert.ToString(test(new[] { "a", "b", "bb", "c", "ccc" }, 1));
            
        }

        static int test(string[] arrayStrings, int Lengte)
        {
            int intStringTeller = 0;

            foreach(string String in arrayStrings)
            {
                if (String.Length == Lengte)
                    intStringTeller++;
            }

            return intStringTeller;
        }
    }
}
