using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTracking.Core
{
    public interface IQueryManager
    {
        Expression<Func<T, bool>> GetExpression<T>(QueryParameter queryParameter);

        List<QueryParameter> GetParameters<T>();

        Expression<Func<T, bool>> GetExpression<T>(List<QueryParameter> parameters);
    }
}

