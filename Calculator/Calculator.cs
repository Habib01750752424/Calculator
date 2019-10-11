using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public double result;

        public double Add(string fNo,string sNo)
        {
            firstNumber = Convert.ToDouble(fNo);
            secondNumber = Convert.ToDouble(sNo);
            result = firstNumber + secondNumber;
            return result;
        }

        public double Subtract(string fNo, string sNo)
        {
            firstNumber = Convert.ToDouble(fNo);
            secondNumber = Convert.ToDouble(sNo);
            result = firstNumber - secondNumber;
            return result;
        }

        public double Multiply(string fNo, string sNo)
        {
            firstNumber = Convert.ToDouble(fNo);
            secondNumber = Convert.ToDouble(sNo);
            result = firstNumber * secondNumber;
            return result;
        }

        public double Division(string fNo, string sNo)
        {
            firstNumber = Convert.ToDouble(fNo);
            secondNumber = Convert.ToDouble(sNo);
            result = firstNumber / secondNumber;
            return result;
        }
    }
}
