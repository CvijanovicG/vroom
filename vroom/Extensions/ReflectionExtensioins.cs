using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vroom.Extensions
{
    public static class ReflectionExtensioins
    {
        public static string GetPropetryValue<T>(this T Item, string propertyName)
        {
            return Item.GetType().GetProperty(propertyName).GetValue(Item, null).ToString();
        }

    }
}
