﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _147
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] arrayStrings = new[] { "Abc", "cdef", "js", "php" };

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = "";

            foreach(string String in arrayStrings)
            {
                lblAntwoord.Text += String.ToUpper() + " ";
            }
        }
    }
}
