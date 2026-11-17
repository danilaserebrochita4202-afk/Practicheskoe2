using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicheskoe2
{
    internal class kalkulator
    {
    // сумма
    static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        // частное
        static double Dev(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя.");
            }

            return firstNumber / secondNumber;
        }
    }
}
