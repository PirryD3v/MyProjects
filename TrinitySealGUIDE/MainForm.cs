﻿using System;
using System.Windows.Forms;

namespace TrinitySealGUIDE
{
    public partial class MainForm : Form
    {

        
        public MainForm()
        {
            InitializeComponent();
            /*if (Form1.Prch == 1)
            {
                InitializeComponent();
            }
            else
            {
                Environment.Exit(1);
            }*/
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
