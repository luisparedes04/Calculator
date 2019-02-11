using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            // initialize Calculator class and MemoryCalculator Class

        Calculator operation = new Calculator();
        MemoryCalculator memory = new MemoryCalculator();

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEqual.Focus();
        }

            // Keyboard Settings for numbers and backspace. numbers in the if's statements represent
            // the character for th keyboard's selcted number. In other words when the user presses 1 on the keyboard
            // C# recognizeses this as the char 49 and I'm using this character to perform an specific button

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49 || e.KeyChar == 97)
            {
                btnOne.PerformClick();
            }
            else if (e.KeyChar == 50 || e.KeyChar == 98)
            {
                btnTwo.PerformClick();
            }
            else if (e.KeyChar == 51 || e.KeyChar == 99)
            {
                btnThree.PerformClick();
            }
            else if (e.KeyChar == 52 || e.KeyChar == 100)
            {
                btnFour.PerformClick();
            }
            else if (e.KeyChar == 53 || e.KeyChar == 101)
            {
                btnFive.PerformClick();
            }
            else if (e.KeyChar == 54 || e.KeyChar == 102)
            {
                btnSix.PerformClick();
            }
            else if (e.KeyChar == 55 || e.KeyChar == 103)
            {
                btnSeven.PerformClick();
            }
            else if (e.KeyChar == 56 || e.KeyChar == 104)
            {
                btnEight.PerformClick();
            }
            else if (e.KeyChar == 57 || e.KeyChar == 105)
            {
                btnNine.PerformClick();
            }
            else if (e.KeyChar == 48 || e.KeyChar == 96)
            {
                btnZero.PerformClick();
            }
            else if (e.KeyChar == 8)
            {
                btnBack.PerformClick();
            }
        }

        // Keyboard settings for period, delete, enter and signs
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.OemPeriod) { btnDot.PerformClick(); }
            else if (e.KeyData == Keys.Delete) { btnClear.PerformClick(); }
            else if (e.KeyData == Keys.Oemplus) { btnPlus.PerformClick(); }
            else if (e.KeyData == Keys.OemMinus) { btnMinus.PerformClick(); }
            else if (e.KeyData == Keys.Multiply) { btnMultiply.PerformClick(); }
            else if (e.KeyData == Keys.Divide) { btnDivide.PerformClick(); }
            else if (e.KeyData == Keys.Enter) { btnEqual.PerformClick(); }

        }
            // End of Keyboard settings

            //Buttons for numbers

        // Every time buttons are clicked they just display the corresponding number to the display label
        private void btnZero_Click(object sender, EventArgs e)
        {
            
            lblDisplay.Text += "0";
            
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "1";
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "2";
            
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "3";
            
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "4";
            
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "5";
            
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "6";
            
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "7";
            
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "8";
            
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "9";
            
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += ".";

        }
        //                           End of numbers and dot buttons

        //                           Operation buttons +, -, *, /, sqrt, 1/x

        // Addition

        // When this button is clicked the code identifies if what is in the display label is a result or not.
        // if what's in the label is a result it set the display to be now the Operand 1. Otherwise,
        // the button just calls the add method from the calculator class passing in whatever is in the label

        private void btnPlus_Click(object sender, EventArgs e)
        {

            lblDisplayOut.Text += lblDisplay.Text + " + ";

            if (operation.Result == true)
            {
                operation.Operand1 = Convert.ToDecimal(lblDisplay.Text);
                operation.Op = "Add";
                operation.Result = false;
                lblDisplayOut.Text = lblDisplay.Text + " + ";
                lblDisplay.Text = string.Empty;
            }

            if (lblDisplay.Text != "")
            {
                operation.Add(Convert.ToDecimal(lblDisplay.Text));
            }

            lblDisplay.Text = string.Empty;
        }

        // Substraction

        // When this button is clicked the code identifies if what's in the display label is a result or not.
        // if what's in the label is a result it sets whatever is in display to be now the Operand 1. Otherwise,
        // the button just calls the substract method from the calculator class passing in whatever is in the label

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblDisplayOut.Text += lblDisplay.Text + " - ";

            if (operation.Result == true)
            {
                if (lblDisplay.Text != "")
                {
                    operation.Operand1 = Convert.ToDecimal(lblDisplay.Text);
                    operation.Op = "Substract";
                    operation.Result = false;
                    lblDisplayOut.Text = lblDisplay.Text + " - ";
                    lblDisplay.Text = string.Empty;
                }
            }

            if (lblDisplay.Text != "")
            {
                operation.Substract(Convert.ToDecimal(lblDisplay.Text));
            }

            lblDisplay.Text = string.Empty;

        }

        // Multiplication

        // When this button is clicked the code identifies if what's in the display label is a result or not.
        // if what's in the label is a result it sets whatever is in display to be now the Operand 1. Otherwise,
        // the button just calls the Multiply method from the calculator class passing in whatever is in the label

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblDisplayOut.Text += lblDisplay.Text + " * "; 

            if (operation.Result == true)
            {
                operation.Operand1 = Convert.ToDecimal(lblDisplay.Text);
                operation.Op = "Multiply";
                operation.Result = false;
                lblDisplayOut.Text = lblDisplay.Text + " * ";
                lblDisplay.Text = string.Empty;     
            }
            if (lblDisplay.Text != "")
            {
                operation.Multiply(Convert.ToDecimal(lblDisplay.Text));
            }

            lblDisplay.Text = string.Empty;
        }

        // Division

        // When this button is clicked the code identifies if what's in the display label is a result or not.
        // if what's in the label is a result it sets whatever is in display to be now the Operand 1. Otherwise,
        // the button just calls the Divide method from the calculator class passing in whatever is in the label

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblDisplayOut.Text += lblDisplay.Text + " / "; 

            if (operation.Result == true)
            {
                if (lblDisplay.Text != "")
                {
                    operation.Operand1 = Convert.ToDecimal(lblDisplay.Text);
                    operation.Op = "Divide";
                    operation.Result = false;
                    lblDisplayOut.Text = lblDisplay.Text + " / ";
                    lblDisplay.Text = string.Empty;
                }
            }

            if (lblDisplay.Text != "")
            {
                operation.Divide(Convert.ToDecimal(lblDisplay.Text));
            }

            lblDisplay.Text = string.Empty;
        }

        // Square Root

        // this button is designed to take whatever is in display at the moment and use th c# built in method
        // call Math.Sqrt which does the square root for us. IMPORTANT: this is executed only if there is a number on display
        // Otherwise it does'nt do anything
        // Also for imaginary number it just display a friendly error to the user

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "")
            {
                lblDisplayOut.Text = "sqrt( " + lblDisplay.Text + " ) = ";
                double result = Math.Sqrt(Convert.ToDouble(lblDisplay.Text));
                lblDisplay.Text = result.ToString();
            }
        }

        // Reciprocal of a number

        // this button is designed to divide 1 by whatever is in display. If the nothing is being displayed
        // the button doesn't do anything

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "")
            {
                lblDisplayOut.Text = "1 / " + lblDisplay.Text + " = ";
                decimal div = Convert.ToDecimal(lblDisplay.Text);
                decimal result = 1 / div;
                lblDisplay.Text = result.ToString();
            }
        }

        //                                  End of Operation Buttons

        //                                  Equal Button

        // when this button is clicked, the code looks at what is in display and if there is a number it calls
        // the Equal method, from the calculator class, that takes in a parameter. Otherwise, it calls
        // the Equal method, from the calculator class, that DOES NOT take any parameter.

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblDisplayOut.Text += lblDisplay.Text + " =";
            
            // In this section a try-catch statement is used so if the user tries to divide by zero the
            // code cathes it (look at line 343) and displays a friendly error message
            try
            {
                if (lblDisplay.Text == "")
                {
                    operation.Equals();
                }
                else
                {
                    operation.Equals(Convert.ToDecimal(lblDisplay.Text));
                }

                lblDisplay.Text = Convert.ToString(operation.CurrentValue);
            }
            catch (ArgumentOutOfRangeException)
            {
                lblDisplay.Text = "Math Error";
            }
        }
        //                          End of Equal Button

        //                          Clear, back and sign buttons

        // Clear button

        // When this button is selected both display labels are cleared and the data members in the
        // calculator class are set to their default values

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = String.Empty;
            lblDisplayOut.Text = String.Empty;
            operation.Clear();
        }

        // Back button

        // When this button is selected only the last digit entered by de user is removed

        private void btnBack_Click(object sender, EventArgs e)
        {
            int lenght = lblDisplay.Text.Length - 1;
            if (lblDisplay.Text != "") { lblDisplay.Text = lblDisplay.Text.Remove(lenght); }
        }

        // Sign button

        // This button is designed to take whatever number is in display and add a negative sign if
        // the number is positive. If the number is already negative the code removes the negative sign making the number positive

        private void btnSigns_Click(object sender, EventArgs e)
        {
            string operand = lblDisplay.Text;

            if (operand.StartsWith("-"))
            {
                lblDisplay.Text = operand.Remove(0, 1);
            }
            else
            {
                lblDisplay.Text = "-" + operand;
            }

        }
        //                                  End of Clear, Back and Sign Buttons

        //                                  Memory Buttons
        
        // Memory Add

        // this button calls the memory add method from the MemoryCalculator class and displays an "M"
        // To let the user now that something has been saved in the memory

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            lblSmallDisplay.Text = "M";
            memory.MemoryAdd(Convert.ToDecimal(lblDisplay.Text));
        }

        // Memory Save

        // this button calls the memory store method from the MemoryCalculator class and displays an "M"
        // To let the user now that something has been saved in the memory

        private void btnMS_Click(object sender, EventArgs e)
        {
            lblSmallDisplay.Text = "M";
            memory.MemoryStore(Convert.ToDecimal(lblDisplay.Text));
        }

        //Memory Clear
        // this button calls the memory clear method from the MemoryCalculator class and removes the "M"
        // From the display to let the user now that the memory is empty

        private void btnMC_Click(object sender, EventArgs e)
        {
            lblSmallDisplay.Text = string.Empty;
            memory.MemoryClear();
        }

        //Memory Recall
        // this button calls the memory recall method from the MemoryCalculator class and
        // displays whatever has been returned in the display label

        private void btnMR_Click(object sender, EventArgs e)
        {
            lblSmallDisplay.Text = "M";
            decimal display = memory.MemoryRecall();
            lblDisplay.Text = display.ToString();
        }

    }
}
