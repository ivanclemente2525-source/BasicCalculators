using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculators
{
    public partial class FrmBasicCalculators : Form
    {
        public FrmBasicCalculators()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtFirstNumber.Text);
            float num2 = float.Parse(txtSecondNumber.Text);
            float total = 0;

            if (cmbOperator.Text == "+")
            {
                total = BasicComputation.Addition(num1, num2);
            }
            else if (cmbOperator.Text == "-")
            {
                total = BasicComputation.Subtraction(num1, num2);
            }
            else if (cmbOperator.Text == "x")
            {
                total = BasicComputation.Multiplication(num1, num2);
            }
            else if (cmbOperator.Text == "÷")
            {
                total = BasicComputation.Division(num1, num2);
            }

            lblResult.Text = total.ToString();
        }
    }
}