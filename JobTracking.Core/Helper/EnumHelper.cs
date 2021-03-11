using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace JobTracking.Core.Helper
{
    public static class EnumHelper
    {
        public static string GetEnumDescription(Enum value)
        {
            if (value != null)
            {
                FieldInfo fi = value.GetType().GetField(value.ToString());
                DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                if (attributes != null && attributes.Any())
                {
                    return attributes.First().Description;
                }
                return value.ToString();
            }
            return null;

        }
    }
}
