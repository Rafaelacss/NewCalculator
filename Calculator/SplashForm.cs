﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Rafaela Silveira
 * Student number: 300910503
 * Date: August, 11, 2017
 * Description: Splash Form Class
 * Version: 0.4 - Created a Public Property as an Alias to Program.calculatorForm
 */

namespace Calculator
{
    public partial class SplashForm : Form
    {
        // PUBLIC PROPERTIES
        public CalculatorForm CalculatorForm
        {
            get
            {
                return Program.calculatorForm;
            }
        }

        // CONSTRUCTORS 

        /// <summary>
        /// This is the main constructor for the SplashForm
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.CalculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false; // turn timer off
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}