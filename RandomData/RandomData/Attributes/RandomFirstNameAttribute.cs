using System;
using RandomData.Helpers;

namespace RandomData.Attributes
{
    public class RandomFirstNameAttribute : Attribute, IRandomGenerator
    {
        private readonly FirstNameType? _nameType;
        public RandomFirstNameAttribute() {
        }

        public RandomFirstNameAttribute(FirstNameType type) {
            _nameType = type;
        }

        public object GenerateValue() {
            //todo this is ugly
            if (_nameType == null) {
                var manOrWomen = RandomNumberGenerator.Instance.NextRandom(2);
                if (manOrWomen % 2 == 1) {
                    var mng = MaleNameGenerator.Instance;
                    var randomNumber = RandomNumberGenerator.Instance.NextRandom(mng.Count);
                    return mng.GetName(randomNumber);
                } else {
                    var mng = FemaleNameGenerator.Instance;
                    var randomNumber = RandomNumberGenerator.Instance.NextRandom(mng.Count);
                    return mng.GetName(randomNumber);
                }
            } else if (_nameType == FirstNameType.MALE) {
                var mng = MaleNameGenerator.Instance;
                var randomNumber = RandomNumberGenerator.Instance.NextRandom(mng.Count);
                return mng.GetName(randomNumber);
            } else if (_nameType == FirstNameType.FEMALE) {
                var mng = FemaleNameGenerator.Instance;
                var randomNumber = RandomNumberGenerator.Instance.NextRandom(mng.Count);
                return mng.GetName(randomNumber);
            }
            return "Ala";

        }
    }
}