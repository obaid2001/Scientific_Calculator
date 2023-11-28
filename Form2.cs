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
    public partial class Form2 : Form
    {
        // intializing variables used for calculations and displaying history 
        double enterFirstValue, enterSecondValue;
        String Option;
        Double result;

        String firstnum, secondnum;
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 SimpleCalculator = new Form1();

            SimpleCalculator.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do You Really Want To Exit", "Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        // Event made for operations which are selected on calculator and storing first value and operation which is selected 
        // then displaying on screen 
        private void operationOnNumbers(object sender, EventArgs e)
        {
            {

                Button num = (Button)sender;
                if (double.TryParse(txtResult.Text, out enterFirstValue))
                {
                    Option = num.Text;
                    result = Double.Parse(txtResult.Text);
                    txtResult.Text = "";
                    labelShowOpt.Text = System.Convert.ToString(result) + " " + Option;

                }
                else
                {
                    // Handle the case where the text cannot be converted to double
                    MessageBox.Show("Please enter a valid number before selecting an operator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResult.Text = "0";
                }

                firstnum = labelShowOpt.Text;
            }
        }

        // Event made for number which are being selected on calculator and entertaining them and show them on screen
        private void inputNumbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (number.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text += number.Text;

                }
                else
                {
                    txtResult.Text += number.Text;
            
                }

            }

        }
        // Using switch case respect to that operation selected result displayed 
        private double currentResult;
        private void btn_Equal_Click(object sender, EventArgs e)
        {
                currentResult = enterFirstValue;
            if (double.TryParse(txtResult.Text, out enterSecondValue))
            {
                secondnum = txtResult.Text;
              
                enterSecondValue = Convert.ToDouble(txtResult.Text);
                labelShowOpt.Text = "";

                switch (Option)
                {
                    case "+":
                        currentResult += enterSecondValue;
                        break;

                    case "-":
                        currentResult -= enterSecondValue;
                        break;

                    case "x":
                        currentResult *= enterSecondValue;
                        break;


                    case "÷":
                        if (enterSecondValue != 0)
                        {
                            currentResult /= enterSecondValue;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtResult.Text = "0";
                            return;
                        }
                        break;

                    case "xʸ":
                        currentResult = Math.Pow(enterFirstValue, enterSecondValue);
                        
                        break;
                    

                    default:
                        break;

                }
                // work for displaying result in history 
                txtResult.Text = currentResult.ToString();
                btnDlete.Visible = true;
                rtbDisplayHistory.AppendText(firstnum + "  " + secondnum + " = ");
                rtbDisplayHistory.AppendText(" " + txtResult.Text + "\n\n");
                lblHistoryDiplay.Text = "";
                rtbDisplayHistory.ScrollBars = RichTextBoxScrollBars.Vertical;
               
            }
            else
            {
                MessageBox.Show("Please enter a valid number before selecting =", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {

            txtResult.Text = "0";
            String entry;
            entry = Convert.ToString(enterSecondValue);
            labelShowOpt.Text = "";
         
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            firstnum = "";
            enterSecondValue = 0;
            enterFirstValue = 0;
            secondnum = "";
            labelShowOpt.Text = "";
         

        }

        private void btnPluMinus_Click(object sender, EventArgs e)
        {
            double minusNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * minusNumber);
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == " ")
            {
                txtResult.Text = "0";

            }
        }
        // using math library calculating square , underroot etc
        private void btnRoot_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(txtResult.Text);

            if (number < 0)
            {
                MessageBox.Show("Square root of a negative number does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";
            }
            else
            {
                double squareRoot = Math.Sqrt(number);
                txtResult.Text = Convert.ToString(squareRoot);
            }
        }

        private void btnXSquare_Click(object sender, EventArgs e)
        {
            double xSqaure = Convert.ToDouble(txtResult.Text);
            double squareOfX = Math.Pow(xSqaure, 2);
            txtResult.Text = Convert.ToString(squareOfX);
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnXCube_Click(object sender, EventArgs e)
        {
            double xCube = Convert.ToDouble(txtResult.Text);
            double cubeOfX = Math.Pow(xCube, 3);
            txtResult.Text = Convert.ToString(cubeOfX);
        }

        // variable used for conversion in degress trignometric functions
        private bool useDegrees = false;

        private void btnRad_Click(object sender, EventArgs e)
        {
            useDegrees = false;
            MessageBox.Show("You Are In Radian Mode","Current Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeg_Click(object sender, EventArgs e)
        {
            useDegrees = true;
            MessageBox.Show("You Are In Degree Mode","Current Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        // method to convert degrees 
        private void CalculateAndDisplay(Func<double, double> trigFunction)
        {
            double x = Convert.ToDouble(txtResult.Text);
            double result;

            if (useDegrees)
            {
                // Convert degrees to radians before calculating
                result = trigFunction(x * Math.PI / 180);

            }
            else
            {
                result = trigFunction(x);
            }

            txtResult.Text = Convert.ToString(result);
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
           
              
            CalculateAndDisplay(Math.Sin);
           
        }
        
        private void btnCos_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay(Math.Cos);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            CalculateAndDisplay(Math.Tan);
        }
        // calculating inverse of sin,cos and tan 
        private void CalculateAndDisplayInverse(double x, Func<double, double> trigFunction)
        {   // condition to check range for inverse value of trigno function 
            if (x < -1 || x > 1)
            {
                MessageBox.Show("Inverse does not exist for the selected value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";
                return;
            }
            double result;

            if (useDegrees)
            {
                // Convert degrees to radians before calculating
                result = trigFunction(x * Math.PI / 180);
            }
            else
            {
                result = trigFunction(x);
            }
            // condition that if inverse of any trig not possible so show dialog box
            if (double.IsNaN(result))
            {
                // Display a message if the result is NaN
                MessageBox.Show("Inverse does not exist for the selected value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";           
            }
            else
            {
                txtResult.Text = Convert.ToString(result);
            }
            
        }
        private void btnSinInverse_Click(object sender, EventArgs e)
        {


            double x = Convert.ToDouble(txtResult.Text);
                CalculateAndDisplayInverse(x, Math.Asin);
            
           
        }

        
        private void btnCosInverse_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
                CalculateAndDisplayInverse(x, Math.Acos);
            
        }

        private void btnTanInverse_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
                CalculateAndDisplayInverse(x, Math.Atan);
            
        }
        // Calculate the factorial
        private void btnFactorial_Click(object sender, EventArgs e)
        {
                    long number = int.Parse(txtResult.Text);           
                    long factorial = CalculateFactorial(number);
                    txtResult.Text = factorial.ToString();    
        }

        // condition if value entered for factorial is below 0 so doesnt work 
        private long CalculateFactorial(long n)
        {
            if (n < 0)
            {
                
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            // Base case: 0! and 1! are both 1
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                // Check for overflow before performing the multiplication
                if (result > long.MaxValue / i)
                {
                    //throw new OverflowException("Factorial calculation resulted in an overflow.");
                    MessageBox.Show("Factorial calculation resulted in an overflow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }

                result *= i;
            }

            return result;
        }

            private void btnSPowerY_Click(object sender, EventArgs e)
        {

        }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void Form2_Load(object sender, EventArgs e)
            {
                this.MinimumSize = new Size(900, 650); // Adjust these values based on your design
                this.MaximumSize = new Size(900, 650);
            }

            private void btn10x_Click(object sender, EventArgs e)
            {
                double x = Convert.ToDouble(txtResult.Text);
                double y = Math.Pow(10, x);
                txtResult.Text = Convert.ToString(y);
            }

            private void btnCLearHistory(object sender, EventArgs e)
            {
                rtbDisplayHistory.Clear();
                if (lblHistoryDiplay.Text == "")
                {

                    lblHistoryDiplay.Text = "There's no history yet ";

                }
                btnDlete.Visible = false;

                rtbDisplayHistory.ScrollBars = 0;
            }
    

       

    }

}

