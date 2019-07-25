namespace crgolden.Sage100
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;

    public static class TypeExtensions
    {
        public static IEnumerable<PropertyInfo> GetWritableProperties<TModel>(this Type type, TModel model)
        {
            return type
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(x =>
                {
                    var value = x.GetValue(model);
                    var attribute = (ReadOnlyAttribute)x.GetCustomAttribute(typeof(ReadOnlyAttribute));
                    return x.Name != "Lines" && value != null && (attribute == null || !attribute.IsReadOnly);
                });
        }
    }
}
