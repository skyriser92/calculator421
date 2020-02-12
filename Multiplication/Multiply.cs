using System;
using MathOperations;

namespace Multiplication
{

    public class Multiply : IMulti
    {
        private dynamic Result;

        public dynamic Multi(dynamic a, dynamic b)
        {

            Result = MathOperations.Multiplication.Multi(a, b);
            return Result;
        }
        public dynamic Multi(dynamic arrayList)
        {
            Result = MathOperations.Multiplication.Multi(arrayList);
            return Result;
        }

    }
}
