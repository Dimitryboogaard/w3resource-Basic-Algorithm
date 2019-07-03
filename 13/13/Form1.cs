using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTemperatuur1, intTemperatuur2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intTemperatuur1 = Convert.ToInt32(tbTemperatuur1.Text);
            intTemperatuur2 = Convert.ToInt32(tbTemperatuur2.Text);

            lblAntwoord.Text = Convert.ToString(Test(intTemperatuur1, intTemperatuur2));
        }

        private static bool Test(int Temperatuur1, int Temperatuur2)
        {
            return Temperatuur1 < 0 && Temperatuur2 > 100 || Temperatuur2 < 0 && Temperatuur1 > 100;
        }
    }
}
