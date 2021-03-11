using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace JobTracking.Core
{
    public class QueryManager : IQueryManager
    {

        private static object LockObject = new object();
        MethodInfo _ListContainsMethod = null;
        MethodInfo _ListContainsNullableMethod = null;
        MethodInfo _ListAnyMethod = null;
        MethodInfo _StringContainsMethod = null;
        MethodInfo _StartsWith = null;
        MethodInfo _EndsWith = null;


        /// <summary>
        /// Creates and returns expression with a parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryParameter"></param>
        /// <returns></returns>
        public Expression<Func<T, bool>> GetExpression<T>(QueryParameter queryParameter)
        {
            var parameter = Expression.Parameter(typeof(T), "entity");

            return GetExpression<T>(queryParameter, parameter);
        }

        /// <summary>
        /// Creates and returns expression with multiple parameters
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Expression<Func<T, bool>> GetExpression<T>(List<QueryParameter> parameters)
        {
            var parameter = Expression.Parameter(typeof(T), "entity");

            Expression<Func<T, bool>> expression = null;

            parameters.Sort((t1, t2) => t1.IsAnd.HasValue.CompareTo(t2.IsAnd.HasValue));

            foreach (var queryParameter in parameters)
            {
                Expression<Func<T, bool>> e = GetExpression<T>(queryParameter, parameter);
                if (expression == null)
                {
                    expression = e;
                }
                else
                {
                    if (queryParameter.IsAnd.HasValue && queryParameter.IsAnd.Value)
                    {
                        expression = Expression.Lambda<Func<T, bool>>(Expression.AndAlso(expression.Body, e.Body), parameter);
                    }
                    else
                    {
                        expression = Expression.Lambda<Func<T, bool>>(Expression.OrElse(expression.Body, e.Body), parameter);
                    }
                }
            }

            return expression;
        }

        /// <summary>
        /// Creates an expression with a single query parameter and parameter expression
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryParameter"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public Expression<Func<T, bool>> GetExpression<T>(QueryParameter queryParameter,
            ParameterExpression parameter)
        {
            var property = Expression.Property(parameter, queryParameter.ColumnName);
            var obj = (T)Activator.CreateInstance(typeof(T));
            Type targetmodeltype = obj.GetType();
            PropertyInfo[] targetprops = targetmodeltype.GetProperties();
            var type = obj.GetType();

            foreach (var targetitem in targetprops)
            {
                if (queryParameter.ColumnName == targetitem.Name)
                {
                    type = targetitem.PropertyType;
                    break;
                }

            }
            object val = queryParameter.Value;

            if (val == null)
            {
                val = Activator.CreateInstance(type);
            }

            Expression expression = null;

            object value = null;

            if (type == typeof(DateTime) || type == typeof(DateTime?) && val != null)
            {
                if (DateTime.TryParse(val.ToString(), out DateTime date))
                {
                    value = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
                }
            }
            else if ((type != typeof(int) && type != typeof(List<int>) && type != typeof(int?)) || queryParameter.ConditionType != ConditionType.Equal)
            {
                value = ConvertValue(val, type);
            }

            switch (queryParameter.ConditionType)
            {
                case ConditionType.Equal:
                    if (type == typeof(int) && val != null && val.ToString().Contains(","))
                    {
                        var stringValues = val.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                        List<int> values = new List<int>();

                        for (int i = 0; i < stringValues.Length; i++)
                        {
                            values.Add(Convert.ToInt32(stringValues[i]));
                        }

                        if (_ListContainsMethod == null)
                        {
                            _ListContainsMethod = typeof(List<int>).GetMethod("Contains", new Type[] { typeof(int) });
                        }
                        expression = Expression.Call(Expression.Constant(values, typeof(List<int>)),
                        _ListContainsMethod,
                        property);
                    }
                    else if (type == typeof(int?) && val != null && val.ToString().Contains(","))
                    {
                        var stringValues = val.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                        List<int?> values = new List<int?>();

                        for (int i = 0; i < stringValues.Length; i++)
                        {
                            values.Add(Convert.ToInt32(stringValues[i]));
                        }

                        if (_ListContainsNullableMethod == null)
                        {
                            _ListContainsNullableMethod = typeof(List<int?>).GetMethod("Contains", new Type[] { typeof(int?) });
                        }
                        expression = Expression.Call(Expression.Constant(values, typeof(List<int?>)),
                        _ListContainsNullableMethod,
                        property);

                    }
                    else if (typeof(IEnumerable<int>).IsAssignableFrom(type) && val != null)
                    {
                        if (val.ToString().Contains(","))
                        {
                            var stringValues = val.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                            List<int> values = new List<int>();

                            List<int> values2 = new List<int>();
                            values.Any(p => values2.Contains(p));

                            for (int i = 0; i < stringValues.Length; i++)
                            {
                                values.Add(Convert.ToInt32(stringValues[i]));
                            }

                            if (_ListContainsMethod == null)
                            {
                                _ListContainsMethod = typeof(List<int>).GetMethod("Contains", new Type[] { typeof(int) });
                            }

                            if (_ListAnyMethod == null)
                            {
                                _ListAnyMethod = typeof(Enumerable).GetMethods().Where(t => t.Name == "Any" && t.GetParameters().Length == 2)
                                    .First().MakeGenericMethod(typeof(int));
                            }

                            Func<int, bool> predicate = p => values.Contains(p);

                            Expression<Func<int, bool>> exp = e => predicate(e);

                            expression = Expression.Call(null,
                            _ListAnyMethod, property, exp);
                        }
                        else
                        {
                            List<int> values = new List<int>();

                            values.Add(Convert.ToInt32(val));

                            if (_ListAnyMethod == null)
                            {
                                _ListAnyMethod = typeof(Enumerable).GetMethods().Where(t => t.Name == "Any" && t.GetParameters().Length == 2)
                                    .First().MakeGenericMethod(typeof(int));
                            }

                            if (_ListContainsMethod == null)
                            {
                                _ListContainsMethod = typeof(List<int>).GetMethod("Contains", new Type[] { typeof(int) });
                            }

                            Func<int, bool> predicate = p => values.Contains(p);

                            Expression<Func<int, bool>> exp = e => predicate(e);

                            expression = Expression.Call(null,
                            _ListAnyMethod, property, exp);
                        }
                    }
                    else
                    {
                        if (value == null)
                        {
                            value = ConvertValue(val, type);
                        }
                        expression = Expression.Equal(property, Expression.Constant(value, type));
                    }
                    break;
                case ConditionType.GreaterThan:

                    expression = Expression.GreaterThan(property, Expression.Constant(value, type));
                    break;
                case ConditionType.LessThan:
                    expression = Expression.LessThan(property, Expression.Constant(value, type));
                    break;
                case ConditionType.LessThanOrEqual:
                    expression = Expression.LessThanOrEqual(property, Expression.Constant(value, type));
                    break;
                case ConditionType.GreaterThanOrEqual:
                    expression = Expression.GreaterThanOrEqual(property, Expression.Constant(value, type));
                    break;
                case ConditionType.IsFalse:
                    expression = Expression.Equal(property, Expression.Constant(false));
                    break;
                case ConditionType.IsTrue:
                    expression = Expression.Equal(property, Expression.Constant(true));
                    break;
                case ConditionType.NotEqual:
                    expression = Expression.NotEqual(property, Expression.Constant(value, type));
                    break;
                case ConditionType.StartsWith:
                    if (_StartsWith == null)
                    {
                        _StartsWith = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });
                    }
                    expression = Expression.Call(property,
                        _StartsWith,
                        Expression.Constant(value, type));
                    break;
                case ConditionType.EndsWith:

                    if (_EndsWith == null)
                    {
                        _EndsWith = typeof(string).GetMethod("EndsWith", new Type[] { typeof(string) });
                    }

                    expression = Expression.Call(property,
                        _EndsWith,
                        Expression.Constant(value, type));
                    break;
                case ConditionType.Contains:

                    if (_StringContainsMethod == null)
                    {
                        _StringContainsMethod = typeof(string).GetMethod("Contains", new Type[] { typeof(string) });
                    }

                    expression = Expression.Call(property,
                        _StringContainsMethod,
                        Expression.Constant(value, type));
                    break;

                default:
                    return null;
            }
            return Expression.Lambda<Func<T, bool>>(expression, parameter);
        }




        public static object ConvertValue(object value, Type destinationType, CultureInfo culture)
        {
            if (value != null)
            {
                if (destinationType == null)
                {
                    throw new ArgumentNullException("destinationType");
                }
                var sourceType = value.GetType();
                if (destinationType == typeof(decimal) || destinationType == typeof(decimal?) && sourceType == typeof(string))
                {
                    value = value.ToString().Replace(",", ".");
                    culture = CultureInfo.InvariantCulture;
                }

                var destinationConverter = GetTypeConverter(destinationType);
                var sourceConverter = GetTypeConverter(sourceType);

                if (destinationConverter != null && destinationConverter.CanConvertFrom(sourceType))
                {
                    return destinationConverter.ConvertFrom(null, culture, value);
                }

                if (sourceConverter != null && sourceConverter.CanConvertTo(destinationType))
                {
                    return sourceConverter.ConvertTo(null, culture, value, destinationType);
                }

                if (destinationType.IsEnum && value is int)
                {
                    return Enum.ToObject(destinationType, (int)value);
                }

                if (!destinationType.IsInstanceOfType(value))
                {
                    return Convert.ChangeType(value, destinationType, culture);
                }
            }
            return value;
        }
        public static object ConvertValue(object value, Type destinationType)
        {
            return ConvertValue(value, destinationType, CultureInfo.CurrentCulture);
        }
        public static TypeConverter GetTypeConverter(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            return TypeDescriptor.GetConverter(type);
        }

        public List<QueryParameter> GetParameters<T>()
        {
            throw new NotImplementedException();
        }
    }
}
