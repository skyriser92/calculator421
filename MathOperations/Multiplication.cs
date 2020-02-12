using System;

namespace MathOperations
{
    public static class multiplication
    {
        static public int Multi(int augEnd, int addEnd)
        {
            var multi = augEnd * addEnd;

            return multi;
        }
        static public decimal Multi(decimal augEnd, decimal addEnd)
        {
            var multi = augEnd * addEnd;

            return multi;
        }

        static public decimal Multi(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach (var x in doubleArray)
            {
                result = Multi(result, x);
            }

            return result;
        }
        static public int Multi(int[] doubleArray)
        {
            int result = 0;

            foreach (var x in doubleArray)
            {
                result = Multi(result, x);
            }

            return result;
        }
    }
}
