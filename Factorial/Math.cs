using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public static class Math
    {
        public static long Factorial(int number)
        {
            long result = 1;
            if (number == 0) return 1;
            for (int i = 2; i <= number; ++i)
            {
                result *= i;
            }
            return result;
        }
    }
}
