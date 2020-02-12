using System;
using MathOperations;

namespace SquareRoot
{
    public class Sqrt : ISqrt
    {
        private dynamic Result;

        public dynamic Sqrt(dynamic a)
        {

            Result = MathOperations.SquareRoot.Sqrt(a);
            return Result;
        }
        public dynamic Sqrt(dynamic arrayList)
        {
            Result = MathOperations.SquareRoot.Sqrt(arrayList);
            return Result;
        }

    }
}
