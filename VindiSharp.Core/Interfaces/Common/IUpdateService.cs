using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Interfaces
{
    public interface IUpdateService<TEntity> where TEntity : class
    {
        TEntity Update(TEntity Entity);
    }
}
