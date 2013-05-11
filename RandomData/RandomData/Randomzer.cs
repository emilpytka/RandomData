/**
 * This class is used for generating sample data for different object.
 * */

using System.Collections.Generic;
using RandomData.Attributes;

namespace RandomData
{
    public class Randomzer<T>
            where T : class, new()
    {
        public T GetRandomeElement() 
        {
            var el = new T();
            var properties = typeof(T).GetProperties();
            foreach (var propertyInfo in properties) {
                var att = propertyInfo.GetCustomAttributes(true);
                foreach (var o in att) {
                    if (o is IRandomGenerator) {
                        var a = o as IRandomGenerator;
                        propertyInfo.SetValue(el, a.GenerateValue(), null);
                    }
                }
            }
            return el;
        }


        public List<T> GetRandomCollection(int count)
        {
            var result = new List<T>();

            var properties = typeof(T).GetProperties();

            for (int i = 0; i < count; i++) {
                var u = new T();

                foreach (var propertyInfo in properties) {
                    var att = propertyInfo.GetCustomAttributes(true);
                    foreach (var o in att) {
                        if (o is IRandomGenerator) {
                            var a = o as IRandomGenerator;
                            propertyInfo.SetValue(u, a.GenerateValue(), null);
                        }
                    }
                }
                result.Add(u);
            }
            return result;
        } 
    }
}
