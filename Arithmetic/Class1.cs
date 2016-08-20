using System;

namespace Arithmetic
{
    /// <summary>
    /// ArithmeticOperations class is responsible for performing 
    /// all Arithmetic operations
    /// </summary>
    public class ArithmeticOperations
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }
        /// <summary>
        /// Addition method performs Addition of two numbers
        /// </summary>
        /// <param name="_firstNum"></param>
        /// <param name="_secondNumber"></param>
        /// <returns>Sum of two numbers</returns>
        public int Addition(int _firstNum,int _secondNumber)
        {
                this.FirstNumber = _firstNum;
                this.SecondNumber = _secondNumber;
                return this.Result = this.FirstNumber + this.SecondNumber;
        }


    }
}
