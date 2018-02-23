using System;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void MathInputs_Changed(object sender, EventArgs e)
        {
            int num_A = (int)NumericUpDownA.Value;
            int num_B = (int)NumericUpDownB.Value;

            int result = 0;

            if (radioButtonAdd.Checked)
            {
                result = MathClass.AddTwoNumbers(num_A, num_B);
            }
            else if (radioButtonSubtract.Checked)
            {
                result = MathClass.SubtractTwoNumbers(num_A, num_B);
            }
            else if (radioButtonMultiply.Checked)
            {
                result = MathClass.MultiplyTwoNumbers(num_A, num_B);
            }
            else if (radioButtonDivide.Checked)
            {
                result = MathClass.DivideTwoNumbers(num_A, num_B);
            }

            LabelResult.Text = result.ToString();
        }
    }
}
