using StrategyPattern.Models;

namespace StrategyPattern.Interfaces
{
    public interface IMathOperator
    {
        Operator Operator { get; }

        int Calculate(int a, int b);
    }
}