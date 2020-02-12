using System;

namespace MathOperations
{
    public static class SquareRoot
    {

        static public decimal Sqrt(decimal augEnd)
        {
            var sum = Math.Sqrt(augEnd);

            return sum;
        }

        static public decimal Sqrt(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach (var x in doubleArray)
            {
                result = SquareRoot(result + x);
            }

            return result;
        }

    }
}
