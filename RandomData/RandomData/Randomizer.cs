using System.Collections.Generic;
using System.Reflection;
using RandomData.Attributes;

namespace RandomData
{
    /// <summary>
    /// Class used for generating sample objects from T class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Randomzer<T>
            where T : class, new()
    {
        /// <summary>
        /// Method generate random element of T class. 
        /// </summary>
        /// <returns></returns>
        public T GetRandomElement() 
        {
            var properties = typeof(T).GetProperties();
            var result = FillElement(properties);
            return result;
        }

        /// <summary>
        /// Method generate collection of random T class elements. 
        /// </summary>
        /// <param name="count">Number of generated elements</param>
        /// <returns>Collection of random elements</returns>
        public IEnumerable<T> GetRandomCollection(int count)
        {
            var result = new List<T>();
            var properties = typeof(T).GetProperties();

            for (int i = 0; i < count; i++)
            {
                var u = FillElement(properties);
                result.Add(u);
            }
            return result;
        }


        /// <summary>
        /// Method create and fill Element with random data
        /// </summary>
        /// <param name="properties">Collection of class properties</param>
        /// <returns>Filled element</returns>
        private static T FillElement(IEnumerable<PropertyInfo> properties)
        {
            var u = new T();

            foreach (var propertyInfo in properties)
            {
                var att = propertyInfo.GetCustomAttributes(true);
                foreach (var o in att)
                {
                    if (o is IRandomGenerator)
                    {
                        var a = o as IRandomGenerator;
                        propertyInfo.SetValue(u, a.GenerateValue(), null);
                    }
                }
            }
            return u;
        }
    }
}
