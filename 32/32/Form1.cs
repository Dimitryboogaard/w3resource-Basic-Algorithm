using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 1, 2, 9, 3 }, 3) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 2, 3 }, 2) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 2, 2, 3 }, 9) + Environment.NewLine;

        }

        private static bool test(int[] arrayGetallen, int intGetal)
        {
            /*
            int intTeller;
            bool booGetalAanwezig = false;
            
            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if(arrayGetallen[intTeller] == intGetal)
                {
                    booGetalAanwezig = true;
                }
            }

            return booGetalAanwezig;
            */
            return arrayGetallen.Contains(intGetal);
        }
    }
}
