﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strTekst;
        int intTeller, intStringLengte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTekst = tbTekst.Text;
            intStringLengte = strTekst.Length;

            lblAntwoord.Text = "";

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(intTeller % 2 == 0)
                {
                    lblAntwoord.Text += strTekst.Substring(intTeller, 1);
                }
            }
        }
    }
}
