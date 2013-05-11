using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class IdentityAttribute : Attribute, IRandomGenerator
    {
        private readonly int _step;
        public IdentityAttribute(int step)
        {
            _step = step;
        }

        public object GenerateValue()
        {
            return IdentityGenerator.Instance.GetNextNum(_step);
        }
    }
}