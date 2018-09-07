using System;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;

namespace MetroSPHelper
{
    /// <summary>
    /// Enum extension
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Get Description attribute from a enum value
        /// </summary>
        /// <param name="enumValue">Enum value</param>
        /// <returns></returns>
        public static string GetDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (field is null)
            {
                return "";
            }

            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (!attributes.Any())
            {
                return "";
            }
            else if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return enumValue.ToString();
            }
        }
    }
}
