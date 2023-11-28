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
    public partial class Form1 : Form
    {
        // intializing variables used for calculations and displaying history 
      double enterFirstValue, enterSecondValue;
        String Option ;
        Double result;
        String firstnum, secondnum;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // adjusting size of windows
            this.MinimumSize = new Size(900, 650); 
            this.MaximumSize = new Size(900, 650);
        }
        
        // Event made for number which are being selected on calculator and entertaining them and show them on screen
        private void InputNumbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (number.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + number.Text;
                    
                }
                else
                {
                    txtResult.Text = txtResult.Text + number.Text  ;
                
                }
            
            }
        }
        // Event made for operations which are selected on calculator and storing first value and operation which is selected 
        // then displaying on screen 
        private void operationOnNumbers(object sender, EventArgs e)
        {


            Button num = (Button)sender;
            if (double.TryParse(txtResult.Text, out enterFirstValue))
            {
                Option = num.Text;
                result = Double.Parse(txtResult.Text);
                txtResult.Text = "";
                labelShowOpt.Text = System.Convert.ToString(result)+ " " + Option;
               
            }
            else
            {
                // Handle the case where the text cannot be converted to double
                MessageBox.Show("Please enter a valid number before selecting an operator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResult.Text = "0";
            }

            firstnum = labelShowOpt.Text;

        }
        // Using switch case respect to that operation selected result displayed on equal btn
        private double currentResult;
        private void btnEqual_Click(object sender, EventArgs e)
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

                    default:
                        break;
                }
                // work for displaying result in history 
                txtResult.Text = currentResult.ToString();
                btnDelte.Visible = true;
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
       
           
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {

            txtResult.Text = "0";
            firstnum = "";
            enterSecondValue = 0;
            enterFirstValue = 0;
            secondnum = "";
            labelShowOpt.Text = "";
           
            /*
            txtResult.Text = "0";
            firstnum = "";
            enterSecondValue = 0;
            enterFirstValue = 0;
            secondnum = "";
        */
            
              }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double minusNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * minusNumber);
        }


        private void btnBackSpace_Click(object sender, EventArgs e)
        { 
            if (txtResult.Text.Length > 0 )
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == " ")
            {
                txtResult.Text = "0";

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnModulas(object sender, EventArgs e)
        {
               double percentage = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(percentage/100); 
        }
        // using math library calculating square , underroot etc
        private void btnSqaureRoot_Click(object sender, EventArgs e)
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

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            double squareOfX = Math.Pow(x, 2);
            txtResult.Text = Convert.ToString(squareOfX);
        }

        private void btnDivideByDefinedVal_Click(object sender, EventArgs e)
        {

            double inputValue = Convert.ToDouble(txtResult.Text);

            if (inputValue != 0)
            {
                double oneDivideX = 1 / inputValue;
                txtResult.Text = Convert.ToString(oneDivideX);
            }
            else
            {
                MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally reset the text box or handle the error in another way
                txtResult.Text = "0";
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do You Really Want To Exit","Simple Calculator" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 scientificForm = new Form2();
            scientificForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void labelShowOpt_Click(object sender, EventArgs e)
        {

        }

        private void btnClearHistory(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
            if (lblHistoryDiplay.Text == "")
            {

                lblHistoryDiplay.Text = "There's no history yet ";

            }
            btnDelte.Visible = false;

            rtbDisplayHistory.ScrollBars = 0;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
          
    }
}
