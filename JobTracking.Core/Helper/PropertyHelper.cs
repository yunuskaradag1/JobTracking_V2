using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace JobTracking.Core.Helper
{
    class PropertyHelper
    {
        public static string GetDescription<T>(string fieldName)
        {
            string result;
            PropertyInfo fi; /*= typeof(T).GetField(fieldName);*/
            Type type = typeof(T);
            PropertyInfo[] props = type.GetProperties();
            var a = props.Where(i => i.Name == fieldName).FirstOrDefault();
            fi = props.Where(i => i.Name == fieldName).FirstOrDefault();

            if (fi != null)
            {
                try
                {
                    object[] descriptionAttrs = fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    DescriptionAttribute description = (DescriptionAttribute)descriptionAttrs[0];
                    result = (description.Description);
                }
                catch
                {
                    result = null;
                }
            }
            else
            {
                result = null;
            }

            return result;
        }
    }
}
