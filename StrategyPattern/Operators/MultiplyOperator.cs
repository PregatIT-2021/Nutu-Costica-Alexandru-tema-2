using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern.Operators
{
    public class MultiplyOperator : IMathOperator
    {
        public Operator Operator => Operator.Multiply;

        public int Calculate(int a, int b) => a * b;
    }
}
