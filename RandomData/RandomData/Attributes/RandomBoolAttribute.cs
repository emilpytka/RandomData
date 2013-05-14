using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class RandomBoolAttribute : Attribute, IRandomGenerator
    {
        public object GenerateValue()
        {
            var a = RandomNumberGenerator.Instance.NextRandom(2);
            return (a%2 == 1);
        }
    }
}