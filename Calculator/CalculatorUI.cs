using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        Calculator calculator = new Calculator();
        string firstNo = "";
        string secondNo = "";

        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            firstNo = firstNoTextBox.Text;
            secondNo = secondNoTextBox.Text;

            resultTextBox.Text = calculator.Add(firstNo, secondNo).ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            resultTextBox.Text = calculator.Subtract(firstNo, secondNo).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            resultTextBox.Text = calculator.Multiply(firstNo, secondNo).ToString();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            resultTextBox.Text = calculator.Division(firstNo, secondNo).ToString();
        }
    }
}
