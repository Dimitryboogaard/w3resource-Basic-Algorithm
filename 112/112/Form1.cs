using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] arrayGetallen = new[] { 1, 5, 6, 5, 6, 17, 5, 6, 3 };
        int intSom, intTeller;
        bool boo56 = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = 0; intTeller < arrayGetallen.Length; intTeller++)
            {
                if (arrayGetallen[intTeller] == 5 && arrayGetallen[intTeller + 1] == 6)
                    boo56 = true;

                else if (boo56 && arrayGetallen[intTeller] == 6)
                    intSom += 0;

                else if (boo56 && arrayGetallen[intTeller] != 6)
                {
                    boo56 = false;
                    intSom += arrayGetallen[intTeller];
                }

                else
                    intSom += arrayGetallen[intTeller];
            }

            lblAntwoord.Text = intSom.ToString();
        }
    }
}
