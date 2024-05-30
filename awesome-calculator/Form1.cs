using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awesome_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            // Retrieve the numbers from the textboxes
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double result = 0;

            // Determine which radio button is checked and perform the corresponding operation
            if (radio_add.Checked)
            {
                result = num1 + num2;
            }
            else if (radio_subtract.Checked)
            {
                result = num1 - num2;
            }
            else if (radio_multiply.Checked)
            {
                result = num1 * num2;
            }
            else if (radio_divide.Checked)
            {
                result = num1 / num2;
            }

            // Display the result in the label
            result_label.Text = "Result: " + result.ToString();
        }
    }
}