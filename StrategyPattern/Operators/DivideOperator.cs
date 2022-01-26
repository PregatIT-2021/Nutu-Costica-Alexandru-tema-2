using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern.Operators
{
    public class DivideOperator : IMathOperator
    {
        public Operator Operator => Operator.Divide;

        public int Calculate(int a, int b) => a / b; // cred ca iti da eroare daca b = 0 :D
    }
}
