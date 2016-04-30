using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Client
{
    public static class VindiNodeUtils
    {
        public static VindiNodeAttribute GetVindiNodeAttribute<TEntity>() where TEntity : class, IVindiEntity, new()
        {
            return (VindiNodeAttribute)Attribute.GetCustomAttribute(typeof(TEntity), typeof(VindiNodeAttribute));
        }
    }
}
