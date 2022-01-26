using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPattern.Services
{
    public class RandomService
    {
        private static readonly Random random = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (random) // synchronize
            {
                return random.Next(min, max);
            }
        }
    }
}
