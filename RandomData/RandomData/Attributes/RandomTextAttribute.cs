using RandomData.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomData.Attributes
{
    /// <summary>
    /// Generates Lorem Ipsum text.
    /// </summary>
    public class RandomTextAttribute : Attribute, IRandomGenerator
    {

        private int _textLength { get; set; }

        public RandomTextAttribute()
        {
            this._textLength = 393; //first paragraph length
        }

        public RandomTextAttribute(int textLength)
        {
            this._textLength = textLength;
        }


        public object GenerateValue()
        {
            var liGenerator = new LoremIpsumGenerator();
            return liGenerator.GetLoremIpsum(this._textLength);
        }
    }
}
