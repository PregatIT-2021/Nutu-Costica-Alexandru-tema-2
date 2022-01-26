using StrategyPattern.Models;

namespace StrategyPattern.Interfaces
{ 
    public interface IMathStrategy
    {
        int Calculate(int a, int b, Operator op);
    }
}