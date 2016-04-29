using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VindiSharp.Core;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;

namespace VindiSharp.Client
{
    public class VindiGenericRepository : IVindiGenericRepository
    {
        IVindiHttpClient vindiClient;

        public IVindiHttpClient Client
        {
            get
            {
                return vindiClient;
            }
        }

        public VindiGenericRepository(IVindiHttpClient vindiClient)
        {
            this.vindiClient = vindiClient;
        }
        public List<TEntity> GetAll<TEntity>(String ResourceName, Int32 Page = 1, Int32 PerPage = 10, List<QueryParameter> Parameters = null, String OrderBy = null, SortOrder? OrderByDirection = null) where TEntity : class, IVindiEntity, new()
        {

            Dictionary<string, object> parameters = new Dictionary<string, object> { };

            parameters["page"] = Page;
            parameters["per_page"] = PerPage;

            if (Parameters != null && Parameters.Count > 0)
                parameters["query"] = String.Join(" AND ", Parameters.Select(item => item.Property + item.Operator.GetSingleAttribute<DescriptionAttribute>().Description + item.Value));

            if (!String.IsNullOrEmpty(OrderBy))
                parameters["sort_by"] = OrderBy;

            if (OrderByDirection.HasValue)
                parameters["sort_order"] = OrderByDirection.Value.GetSingleAttribute<DescriptionAttribute>().Description;

            VindiNodeAttribute attribute = GetVindiNodeAttribute<TEntity>();

            return vindiClient.Do<List<TEntity>>(ResourceName, attribute.MultiResultsNodeName, VindiRequestMethod.Get, parameters);
        }

        private VindiNodeAttribute GetVindiNodeAttribute<TEntity>() where TEntity : class, IVindiEntity, new()
        {
            return (VindiNodeAttribute)Attribute.GetCustomAttribute(typeof(TEntity), typeof(VindiNodeAttribute));
        }

        public TEntity GetById<TEntity>(String ResourceName, long Id)
            where TEntity : class, IVindiEntity, new()
        {
            VindiNodeAttribute attribute = GetVindiNodeAttribute<TEntity>();

            return vindiClient.Do<TEntity>(String.Format("{0}/{1}", ResourceName, Id), attribute.SingleResultNodeName, VindiRequestMethod.Get);
        }
        public TEntity Insert<TEntity>(String ResourceName, TEntity Entity)
            where TEntity : class, IVindiEntity, new()
        {
            VindiNodeAttribute attribute = GetVindiNodeAttribute<TEntity>();

            return vindiClient.Do<TEntity, TEntity>(ResourceName, attribute.SingleResultNodeName, VindiRequestMethod.Post, Entity);
        }
        public TEntity Update<TEntity>(String ResourceName, long Id, TEntity Entity)
            where TEntity : class, IVindiEntity, new()
        {
            VindiNodeAttribute attribute = GetVindiNodeAttribute<TEntity>();

            return vindiClient.Do<TEntity, TEntity>(String.Format("{0}/{1}", ResourceName, Id), attribute.SingleResultNodeName, VindiRequestMethod.Put, Entity);
        }
        public TEntity Delete<TEntity>(String ResourceName, long Id)
           where TEntity : class, IVindiEntity, new()
        {
            VindiNodeAttribute attribute = GetVindiNodeAttribute<TEntity>();

            return vindiClient.Do<TEntity>(String.Format("{0}/{1}", ResourceName, Id), attribute.SingleResultNodeName, VindiRequestMethod.Delete);
        }
    }
}
