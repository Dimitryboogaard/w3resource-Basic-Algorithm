using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _113
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 1, 5, 6, 9, 10, 17 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 5, 5, 9, 10, 17 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 5, 5, 9, 10, 17, 5, 5 }) + Environment.NewLine;

        }

        public bool test(int[] arrayGetallen)
        {
            int intTeller;
            for(intTeller = 0; intTeller < arrayGetallen.Length - 1; intTeller++)
            {
                if (arrayGetallen[intTeller] == 5 && arrayGetallen[intTeller + 1] == 5)
                    return true;
            }

            return false;

        }
    }
}
