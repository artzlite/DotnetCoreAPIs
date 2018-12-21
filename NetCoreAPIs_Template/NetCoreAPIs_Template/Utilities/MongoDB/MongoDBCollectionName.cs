using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Utilities.MongoDB
{
    public static class MongoDBCollectionName
    {
        public static string things
        {
            get { return GetName(() => things); }
        }

        public static string user
        {
            get { return GetName(() => user); }
        }

        public static string configgroups
        {
            get { return GetName(() => configgroups); }
        }

        public static string thingsdatas
        {
            get { return GetName(() => thingsdatas); }
        }

        #region private method
        private static string GetName<T>(Expression<Func<T>> memberExpression)
        {
            MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
            return expressionBody.Member.Name;
        }
        #endregion
    }

}
