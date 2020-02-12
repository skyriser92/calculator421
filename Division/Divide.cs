using System;
using MathOperations;

namespace Division
{

    public class Divide : IDivide
    {
        private dynamic Result;

        public dynamic Divide(dynamic a, dynamic b)
        {

            Result = MathOperations.Division.Divide(a, b);
            return Result;
        }
        public dynamic Divide(dynamic arrayList)
        {
            Result = MathOperations.Division.Divide(arrayList);
            return Result;
        }

    }
}
