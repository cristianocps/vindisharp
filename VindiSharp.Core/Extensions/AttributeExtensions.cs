using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VindiSharp.Core
{
    public static class AttributeExtensions
    {
        public static IEnumerable<TAttribute> GetAttribute<TAttribute>(this object e) where TAttribute : Attribute
        {
            Type type = e.GetType();

            MemberInfo[] memInfo = type.GetMember(e.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(TAttribute),
                                                            false);
                if (attrs != null && attrs.Length > 0)
                    return attrs.Select(item => item as TAttribute);
            }

            return null;
        }
        public static TAttribute GetSingleAttribute<TAttribute>(this object e) where TAttribute : Attribute
        {
            IEnumerable<TAttribute> result = e.GetAttribute<TAttribute>();

            if (result != null && result.Count() > 0)
                return result.SingleOrDefault();

            return null;
        }
    }
}
