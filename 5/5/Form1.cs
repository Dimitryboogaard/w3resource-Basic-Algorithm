﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strZin;
        bool booStartMetIf;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strZin = tbZin.Text;

            booStartMetIf = strZin.StartsWith("if");

            lblAntwoord.Text = booStartMetIf ? strZin : "if " + strZin;
        }
    }
}
