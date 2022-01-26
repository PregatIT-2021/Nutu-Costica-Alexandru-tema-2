using StrategyPattern.Interfaces;
using StrategyPattern.Models;

namespace StrategyPattern.Operators
{
    public class SubstractOperator : IMathOperator
    {
        public Operator Operator => Operator.Substract;

        public int Calculate(int a, int b) => a - b;
    }
}