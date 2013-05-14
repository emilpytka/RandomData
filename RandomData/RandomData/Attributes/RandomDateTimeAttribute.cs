using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class RandomDateTimeAttribute : Attribute, IRandomGenerator
    {
        private DateTime? _startTime;
        private DateTime? _endTime;

        public object GenerateValue()
        {
            if (_startTime != null && _endTime != null)
            {
                var range = (int)(_endTime.Value - _startTime.Value).TotalDays;
                return _startTime.Value.AddDays(RandomNumberGenerator.Instance.NextRandom(range));
            }
            else
            {
                var start = new DateTime(1995, 1, 1);
                var range = (int) (DateTime.Today - start).TotalDays;
                return start.AddDays(RandomNumberGenerator.Instance.NextRandom(range));
            }
        }

        public RandomDateTimeAttribute()
        {   
        }

        public RandomDateTimeAttribute(string startTime, string endTime)
        {
            _startTime = DateTime.Parse(startTime);
            _endTime = DateTime.Parse(endTime);
        }
    }
}