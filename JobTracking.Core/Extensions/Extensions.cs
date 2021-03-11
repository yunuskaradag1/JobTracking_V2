using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace JobTracking.Core.Extensions
{
    public static class Extensions
    {

        public static IQueryable<T> GetOrderData<T>(this IQueryable<T> data, PageQuery m)
        {
            if (!string.IsNullOrEmpty(m.OrderColumn) && !string.IsNullOrEmpty(m.OrderDir))
            {
                var param = Expression.Parameter(typeof(T), "item");



                var sortExpression = Expression.Lambda<Func<T, object>>
                    (Expression.Convert(Expression.Property(param, m.OrderColumn), typeof(object)), param);

                switch (m.OrderDir.ToLower())
                {
                    case "asc":
                        data = data.AsQueryable<T>().OrderBy<T, object>(sortExpression);
                        break;
                    default:
                        data = data.AsQueryable<T>().OrderByDescending<T, object>(sortExpression);
                        break;

                }
            }

            return data;
        }
        public static JobTrackingDataSource<T> ToDataSource<T>(this IQueryable<T> items, PageQuery query, IQueryManager manager)
        {
            JobTrackingDataSource<T> source = new JobTrackingDataSource<T>();

            Expression<Func<T, bool>> expression = null;

            if (query.Parameters != null)
            {
                expression = manager.GetExpression<T>(query.Parameters.OfType<QueryParameter>().ToList());
                if (expression != null)
                {
                    items = items.Where(expression);
                }
            }

            if (!string.IsNullOrEmpty(query.OrderColumn))
            {
                items = items.GetOrderData<T>(query);
            }
            source.Count = items.Count();

            int page = query.PageNumber + 1;

            if (query.PageSize > 0)
            {
                source.Items = items.Skip((page - 1) * query.PageSize).Take(query.PageSize).ToList();
            }
            else
            {
                source.Items = items.ToList();
            }

            return source;
        }
        public static JobTrackingDataSource<T> ToDataSourceCount<T>(this IQueryable<T> items, PageQuery query, IQueryManager manager)
        {
            JobTrackingDataSource<T> source = new JobTrackingDataSource<T>();

            Expression<Func<T, bool>> expression = null;

            if (query.Parameters != null)
            {
                expression = manager.GetExpression<T>(query.Parameters.OfType<QueryParameter>().ToList());
                if (expression != null)
                {
                    items = items.Where(expression);
                }
            }
            source.Count = items.Count();
            return source;
        }
        public static IQueryable<T> ApplyParameters<T>(this IQueryable<T> items, PageQuery query, IQueryManager manager)
        {
            if (!string.IsNullOrEmpty(query.OrderColumn))
            {
                //Type type = typeof(T);

                //var property = reflectionService.GetProperty(typeof(T), query.OrderColumn);
                //var property = Expression.Property(parameter, queryParameter.ColumnName);

                var obj = (T)Activator.CreateInstance(typeof(T));
                Type targetmodeltype = obj.GetType();
                PropertyInfo[] targetprops = targetmodeltype.GetProperties();
                var type = obj.GetType();
                PropertyInfo property = null;

                foreach (var targetitem in targetprops)
                {
                    if (query.OrderColumn == targetitem.Name)
                    {
                        type = targetitem.PropertyType;
                        property = targetitem;
                        break;
                    }

                }
                ParameterExpression arg = Expression.Parameter(type, "x");

                if (property != null)
                {
                    Expression expr = Expression.Property(arg, property);
                    type = property.PropertyType;

                    Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
                    LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

                    String methodName = query.OrderDir == "desc" ? "OrderByDescending" : "OrderBy";
                    items = typeof(Queryable).GetMethods().Single(
                        method => method.Name == methodName
                                && method.IsGenericMethodDefinition
                                && method.GetGenericArguments().Length == 2
                                && method.GetParameters().Length == 2)
                        .MakeGenericMethod(typeof(T), type)
                        .Invoke(null, new object[] { items, lambda }) as IQueryable<T>;
                }
            }

            Expression<Func<T, bool>> expression = null;

            if (query.Parameters != null)
            {
                expression = manager.GetExpression<T>(query.Parameters.OfType<QueryParameter>().ToList());
                if (expression != null)
                {
                    items = items.Where(expression);
                }
            }

            int page = query.PageNumber + 1;

            if (query.PageSize > 0)
            {
                return items.Skip((page - 1) * query.PageSize).Take(query.PageSize);
            }
            else
            {
                return items;
            }
        }

      
        public static string ToJson(this object value)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            return JsonConvert.SerializeObject(value, Formatting.Indented, settings);
        }



        public static DateTime? UnixTimeStampToDateTime(this double unixTimeStamp)
        {
            if (unixTimeStamp != null)
            {
                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
                return dtDateTime;
            }
            return null;

        }
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static string CompanyIdentifier(this string identifier)
        {
            string s = "";

            for (int i = 0; i < identifier.Length; i++)
            {
                if (i < 2)
                {
                    s += identifier[i];
                    continue;
                }
                if (i > identifier.Length - 3)
                {
                    s += identifier[i];
                    continue;
                }
                if (identifier[i].Equals('.') || identifier[i].Equals('-'))
                {
                    s += identifier[i];
                    continue;
                }
                s += "*";
            }
            return s;
        }

    }
}
