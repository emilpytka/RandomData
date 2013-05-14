using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class RandomNumberAttribute : Attribute, IRandomGenerator
    {
        private int? _from;
        private int? _to;

        public RandomNumberAttribute() {
        }

        public RandomNumberAttribute(int from, int to) {
            _from = from;
            _to = to;
        }

        public object GenerateValue() {
            if (_from != null && _to != null) {
                return _from + RandomNumberGenerator.Instance.NextRandom(_to.Value - _from.Value);
            } else {
                return RandomNumberGenerator.Instance.NextRandom(int.MaxValue);
            }
        }
    }
}
