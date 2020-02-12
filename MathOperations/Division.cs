using System;

namespace MathOperations
{
    public static class Division
    {
        static public int Divide(int augEnd, int addEnd)
        {
            var divide = augEnd / addEnd;

            return divide;
        }
        static public decimal Multi(decimal augEnd, decimal addEnd)
        {
            var divide = augEnd / addEnd;

            return divide;
        }

        static public decimal Divide(decimal[] doubleArray)
        {
            decimal result = 0;

            foreach (var x in doubleArray)
            {
                result = Divide(result, x);
            }

            return result;
        }
        static public int Divide(int[] doubleArray)
        {
            int result = 0;

            foreach (var x in doubleArray)
            {
                result = Divide(result, x);
            }

            return result;
        }
    }
}
