using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class QueryParameter
    {
        public string ColumnName { get; set; }
        public string Value { get; set; }
        public int Condition { get; set; }
        public bool? IsAnd { get; set; }

        public int PropertyType { get; set; }

        public string PropertyText { get; set; }

        public ConditionType ConditionType
        {
            get
            {
                return (ConditionType)Condition;
            }
            set
            {
                Condition = (int)value;
            }
        }
        public QueryParameter()
        {
            IsAnd = true;
        }
    }
}
