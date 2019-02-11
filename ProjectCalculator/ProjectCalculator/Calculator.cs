using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    public class Calculator:ICalculator
    {
        // Data members

        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private string op;
        private bool result = false;
        private enum Operator
        {
            Add,
            Substract,
            Multiply,
            Divide,
            none
        };

        //Properties

        public decimal CurrentValue { get => currentValue; set => currentValue = value; }
        public string Op { get => op; set => op = value; }
        public bool Result { get => result; set => result = value; }
        public decimal Operand1 { get => operand1; set => operand1 = value; }


        // Default Constructor 

        public Calculator()
        {
            this.Operand1 = 0;
            this.operand2 = 0;
            this.CurrentValue = 0;
            this.Op = Convert.ToString(Operator.none);
        }

        //                              Operation Methods

        // Additon Method
        // this method is design to add the value that is passed in, to the current value and operand one 
        //and set operator to Add

        public void Add(decimal displayValue)
        {
            this.CurrentValue += displayValue;
            this.Operand1 += displayValue; 
            this.Op = Convert.ToString(Operator.Add);
        }

        // Substraction Method

        // this method is design to substract the value that is passed in, to the current value and operand one 
        // and set operator to Substract. BUT when the current value is equal to zero (or when the calculator is launched for the first time)
        // it sets the current value and operand one to the value that is passed in to avoid getting negative logic error.
        // Otherwise, if the users does 10 - 1 the result would be -11 instead of 9 

        public void Substract(decimal displayValue)
        {
            if (this.CurrentValue != 0)
            {
                CurrentValue -= displayValue;
                this.Operand1 -= displayValue;
            }
            else
            {
                this.CurrentValue = displayValue;
                this.Operand1 = displayValue;
            }

            this.Op = Convert.ToString(Operator.Substract);
        }

        // Multiplication Method

        // this method is design to multiply the value that is passed in by the current value and operand one 
        // and set operator to Multiply. BUT when the current value is equal to zero (or when the calculator is launched for the first time)
        // it sets the current value and operand one to the value that is passed in to avoid getting logic error.
        // Otherwise, if the users does 2 * 2 * 2 the result would be 4 instead of 8 

        public void Multiply(decimal displayValue)
        {
            if (this.CurrentValue != 0) {
                CurrentValue *= displayValue;
                this.Operand1 *= displayValue;
            }
            else
            {
                this.CurrentValue = displayValue;
                this.Operand1 = displayValue;
            }
            
            this.Op = Convert.ToString(Operator.Multiply);
        }

        // Division Method

        // this method is design to divide the current value and operand one by the value that is passed in
        // and set operator to Substract. BUT when the current value is equal to zero (or when the calculator is launched for the first time)
        // it sets the current value and operand one the the value that is passed in to avoid logic error.

        public void Divide(decimal displayValue)
        {

            if (this.CurrentValue != 0)
            {

                CurrentValue /= displayValue;
                this.Operand1 /= displayValue;
            }
            else
            {
                this.CurrentValue = displayValue;
                this.Operand1 = displayValue;
            }

            this.Op = Convert.ToString(Operator.Divide);
        }

        //                                  Execution methods

        // Equals Method with NO parameters passed

        // This method is design to execute the operation, based on the operator previously set, by any of the "Operation Methods", and based only on operand one or current value
        // For example: if the user does 2 * and presses equals this method is called and throws back a result of 4.
        // Also this method sets a boolan called result to true which affects the code in the Form.cs when necessary
        public void Equals()
        {
            if (Op == "Add")
            {
                this.Add(this.CurrentValue);
                this.Result = true;
            }
            else if (Op == "Substract")
            {
                this.Substract(this.CurrentValue);
                this.Result = true;
            }
            else if (Op == "Multiply")
            {
                this.CurrentValue = this.Operand1 * this.Operand1;
                this.Result = true;
            }
            else if(Op == "Divide")
            {
                if (Operand1 == 0) { throw new ArgumentOutOfRangeException("Math Error"); }
                this.CurrentValue = this.Operand1 / this.Operand1;
                this.Result = true;
            }
        }

        // Equals Method passing a parameter

        // This method is design to set operand two, to the value that is passed in and perform the operation based on the
        // the operator previously set by any of the "Operation Methods".
        // Also this method sets a boolan called result to true which affects the code in the Form.cs when necessary

        public void Equals(decimal displayValue)
        {
            this.operand2 = displayValue;

            if (Op == "Add")
            {
                this.CurrentValue = this.Operand1 + this.operand2;
                this.Result = true;
            }
            else if (Op == "Substract")
            {
                this.CurrentValue = this.Operand1 - this.operand2;
                this.Result = true;
            }
            else if (Op == "Multiply")
            {
                this.CurrentValue = this.Operand1 * this.operand2;
                this.Result = true;
            }
            else if (Op == "Divide")
            {
                // here, if the value that is passed in is zero the code is going to throw an error which will be catch in the Form.cs and will trigger a friendly message to the user
                if (operand2 == 0) { throw new ArgumentOutOfRangeException("Math Error"); }
                this.CurrentValue = this.Operand1 / this.operand2;
                this.Result = true;
            }
        }
        //                              End of execution methods

        // Clear Method
        // This method is design to set all data members to their default values 

        public void Clear()
        {
            this.Operand1 = 0;
            this.operand2 = 0;
            this.CurrentValue = 0;
            this.Op = Convert.ToString(Operator.none);
            this.Result = false;
        }
    }
}
