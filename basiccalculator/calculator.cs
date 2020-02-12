using System;
using MathOperations;
using Addition;
using Subtraction;
using Multiplication;
using Division;
using SquareRoot;

namespace basiccalculator
{
    public class Calculator : IAdd, ISubtract, IMulti, IDivide, ISqrt
    {
        private dynamic _result;

        public dynamic Result
        {
            get => _result;
            set => _result = value;
        }

        Adding Addition = new Adding();
        Difference Subtraction = new Difference();
        Multiply Multiplication = new Multiply();
        Divide Division = new Divide();
        Sqrt SquareRoot = new Sqrt();

        public dynamic Sum(dynamic a, dynamic b)
        {
            Result = Addition.Sum(a, b);
            return Result;

        }
        public dynamic Sum(dynamic arrayList)
        {
            Result = Addition.Sum(arrayList);
            return Result;
        }

        public int Subtract(int a, int b)
        {
            Result = Subtraction.Subtract(a, b);
            return Result;

        }

        public dynamic Multi(dynamic a, dynamic b)
        {
            Result = Multiplication.Multi(a, b);
            return Result;

        }
        public dynamic Multi(dynamic arrayList)
        {
            Result = Multiplication.Multi(arrayList);
            return Result;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            Result = Division.Divide(a, b);
            return Result;

        }
        public dynamic Divide(dynamic arrayList)
        {
            Result = Division.Divide(arrayList);
            return Result;
        }

        public dynamic Sqrt(dynamic a)
        {
            Result = SquareRoot.Sqrt(a);
            return Result;

        }
        public dynamic Sqrt(dynamic arrayList)
        {
            Result = SquareRoot.Sqrt(arrayList);
            return Result;
        }

    }
}
