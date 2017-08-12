using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Rafaela Silveira
 * Student number: 300910503
 * Date: August, 11, 2017
 * Description: Calculator Demo Project
 * Version: 0.2 - started splah
 */

namespace Calculator
{
    public static class Program
    {
        // Create Reference to Forms
        public static CalculatorForm calculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate a new object of type CalculatorForm
            calculatorForm = new CalculatorForm();

            Application.Run(new SplashForm());
        }
    }
}