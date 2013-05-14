using System;

namespace RandomData.Helpers
{
    public class RandomNumberGenerator
    {
        private static RandomNumberGenerator _instance;

        public static RandomNumberGenerator Instance
        {
            get { return _instance ?? (_instance = new RandomNumberGenerator()); }
        }

        private readonly Random _randomizator;

        private RandomNumberGenerator()
        {
            _randomizator = new Random();
        }

        public int NextRandom(int i)
        {
            return _randomizator.Next(i);
        }
    }
}