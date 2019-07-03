using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2, intGetal3;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = int.Parse(tbGetal1.Text);
            intGetal2 = int.Parse(tbGetal2.Text);
            intGetal3 = int.Parse(tbGetal3.Text);

            lblAntwoord.Text = Convert.ToString(test(intGetal1, intGetal2, intGetal3));
        }

        public static int test(int Getal1, int Getal2, int Getal3)
        {
            return waarde(Getal1) + waarde(Getal2) + waarde(Getal3);
        }
        public static int waarde(int Getal)
        {
            return Getal >= 10 && Getal <= 20 && Getal != 13 && Getal != 17 ? 0 : Getal;
        }

    }
}
