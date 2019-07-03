using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test("abcdefgh", "abijsklm") + Environment.NewLine;
            rtUitvoer.Text += test("abcde", "osuefrcd") + Environment.NewLine;
            rtUitvoer.Text += test("pqrstuvwx", "pqkdiewx");
        }

        private static int test(string strTekst1, string strTekst2)
        {
            var intPositie = 0;

            for(int intTeller = 0; intTeller < strTekst1.Length - 1; intTeller++)
            {
                for(int intTeller2 = 0; intTeller2 < strTekst2.Length - 1; intTeller2++)
                {
                    if(strTekst1.Substring(intTeller, 2) == strTekst2.Substring(intTeller2, 2))
                    {
                        intPositie = intTeller2;
                    }
                }
            }

            return intPositie;
        }
    }
}
