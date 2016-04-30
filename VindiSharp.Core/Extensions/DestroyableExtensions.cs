using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Core.Extensions
{
    public static class DestroyableExtensions
    {
        public static void Destroy(this IEnumerable<IDestroyableEntity> collection, IDestroyableEntity item)
        {
            item.Destroy = true;

            SetNullableProperties(item);
        }
        private static void SetNullableProperties(object item)
        {
            Func<PropertyInfo, bool> IsNullableProperty = prop =>
            {
                Type propType = prop.PropertyType;

                return propType == typeof(string) || (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>));
            };

            Type type = item.GetType();

            string[] ignoredPropNames = { "Id", "Destroy" };

            IEnumerable<PropertyInfo> properties = type.GetProperties().Where(prop => !ignoredPropNames.Contains(prop.Name) && IsNullableProperty(prop));

            foreach (PropertyInfo prop in properties)
            {
                prop.SetValue(item, null, new object[] { });
            }

        }


    }
}
