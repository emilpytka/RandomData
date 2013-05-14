using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class RandomValueAttribute : Attribute, IRandomGenerator
    {
        private readonly string[] _values;
        public RandomValueAttribute(params String[] values )
        {
            _values = values;
        }

        public object GenerateValue()
        {
            var index = RandomNumberGenerator.Instance.NextRandom(_values.Length);
            return _values[index];
        }
    }
}