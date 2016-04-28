using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Entities;

namespace VindiSharp.Core.Interfaces
{
    public interface IPlanService :
         IDeleteService<Plan>,
         IInsertService<Plan>,
         IUpdateService<Plan>,
         ISearchService<Plan>

    {

    }
}
