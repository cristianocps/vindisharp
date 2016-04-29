﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Interfaces
{
    public interface IDeleteService<TEntity> where TEntity : class
    {
        void Delete(long Id);
    }
}