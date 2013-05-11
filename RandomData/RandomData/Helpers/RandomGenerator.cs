using System;

namespace RandomData.Helpers
{
    public class RandomGenerator
    {
        private static RandomGenerator _instance;

        public static RandomGenerator Instance
        {
            get { return _instance ?? (_instance = new RandomGenerator()); }
        }

        private readonly Random _randomizator;

        private RandomGenerator()
        {
            _randomizator = new Random();
        }

        public int NextRandom(int i)
        {
            return _randomizator.Next(i);
        }
    }
}