using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;

namespace ValidationAttributes
{
   public static class Validator
    {
        public static bool IsValid(Object obj)
        {
            //get object props
            //foreach props check if there is custom attributes
            //isValid(value)
            //model is valid or not valid
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                IEnumerable<MyValidationAttribute> propertCustomAttributes = property
                    .GetCustomAttributes()
                    .Where(x=>x is MyValidationAttribute)
                    .Cast<MyValidationAttribute>();

                foreach (MyValidationAttribute attribute in propertCustomAttributes)
                {
                    bool result = attribute.IsValid(property.GetValue(obj));

                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
