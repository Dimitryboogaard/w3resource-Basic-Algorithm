﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            rtUitvoer.Text += test(new[] { 1, 1, 2, 2, 1 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 1, 2, 1, 2, 3 }) + Environment.NewLine;
            rtUitvoer.Text += test(new[] { 1, 1, 1, 2, 2, 2, 1 });

        }

        public static bool test(int[] arrayGetallen)
        {
            

            for(int intTeller = 0; intTeller < arrayGetallen.Length - 2; intTeller++)
            {
                if(arrayGetallen[intTeller] == arrayGetallen[intTeller + 1] &&
                   arrayGetallen[intTeller + 1] == arrayGetallen[intTeller + 2])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
