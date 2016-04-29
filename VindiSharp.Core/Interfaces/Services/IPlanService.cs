using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface IPlanService :
         IInsertService<Plan>,
         IUpdateService<Plan>,
         ISearchService<Plan>

    {
        Plan GetByCode(String code);
    }
}
