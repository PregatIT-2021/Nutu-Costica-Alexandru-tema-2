using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    public class MathStrategy : IMathStrategy
    {
        private readonly IEnumerable<IMathOperator> _operators;

        public MathStrategy(IEnumerable<IMathOperator> operators)
        {
            _operators = operators;
            
            foreach (var op in operators)
            {
                Console.WriteLine(op.Operator);
            }
        }

        public int Calculate(int a, int b, Operator op)
        {
            return _operators.FirstOrDefault(x => x.Operator == op)?.Calculate(a, b) ?? throw new ArgumentNullException(nameof(op));
        }
    }
}