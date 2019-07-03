using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _98
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 12, 20 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 14, 15 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 11, 21 });

        }

        public static bool test(int[] arrayGetallen)
        {
            bool booGeen15Of20 = false;

            foreach(int Getal in arrayGetallen)
            {
                booGeen15Of20 = Getal != 15 && Getal != 20;
            }

            return booGeen15Of20;
        }
    }
}
