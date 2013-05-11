﻿using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class RandomLastNameAttribute : Attribute, IRandomGenerator
    {
        public object GenerateValue()
        {
            var lnGenerator = LastNameGenerator.Instance;
            var randomNum = RandomGenerator.Instance.NextRandom(lnGenerator.Count);
            return lnGenerator.GetLastName(randomNum);
        }
    }
}