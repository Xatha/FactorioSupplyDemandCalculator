using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorioSupplyDemandCalculatorUI
{
    internal class InputValidator
    {
        internal bool IsInputValid(string input)
        {
            bool result = false;
            if (IsInputANumber(input))
            {
                result = true;
            }
            Console.WriteLine($"IsInputValid(): {result}");
            return result;
        }

        private bool IsNumberSane(double number)
        {
            var result = number <= 10_000 && 0 < number;
            Console.WriteLine($"IsNumbeSane(): {result}");
            return result;

        }
        private bool IsInputANumber(string input)
        {
            bool result = false; 
            if (double.TryParse(input, out double number))
            {
                result = IsNumberSane(number);
            }

            Console.WriteLine($"IsInputANumber(): {result}");


            return result;
        }
    }
}
