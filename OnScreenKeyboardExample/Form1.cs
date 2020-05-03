﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnScreenKeyboardExample
{
    public partial class Form1 : Form
    {
        private bool capsPressed = false; // to add functionallity
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
 
        }
        public Form1()
        {
            InitializeComponent();
            SButton.Click += StandardKeyPress;
            AButton.Click += StandardKeyPress;
            WButton.Click += StandardKeyPress;
            DButton.Click += StandardKeyPress;
        }

        private void StandardKeyPress(object sender, EventArgs e)
        {
            var button = sender as Button;
            SendKeys.Send(capsPressed ? button.Text.ToUpper() : button.Text.ToLower());
        }
    }
}