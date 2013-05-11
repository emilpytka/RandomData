using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class RandomFirstNameAttribute : Attribute, IRandomGenerator
    {
        private FirstNameType? _nameType;
        public RandomFirstNameAttribute() {
        }

        public RandomFirstNameAttribute(FirstNameType type) {
            _nameType = type;
        }

        public object GenerateValue() {
            if (_nameType == null) {
                var manOrWomen = RandomGenerator.Instance.NextRandom(2);
                if (manOrWomen % 2 == 1) {
                    var mng = MaleNameGenerator.Instance;
                    var randomNumber = RandomGenerator.Instance.NextRandom(mng.Count);
                    return mng.GetName(randomNumber);
                } else {
                    var mng = FemaleNameGenerator.Instance;
                    var randomNumber = RandomGenerator.Instance.NextRandom(mng.Count);
                    return mng.GetName(randomNumber);
                }
            } else if (_nameType == FirstNameType.MALE) {
                var mng = MaleNameGenerator.Instance;
                var randomNumber = RandomGenerator.Instance.NextRandom(mng.Count);
                return mng.GetName(randomNumber);
            } else if (_nameType == FirstNameType.FEMALE) {
                var mng = FemaleNameGenerator.Instance;
                var randomNumber = RandomGenerator.Instance.NextRandom(mng.Count);
                return mng.GetName(randomNumber);
            }
            return "Ala";

        }
    }
}