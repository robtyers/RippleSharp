using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace RippleSharp.Rippled.Json
{
    public static class Extensions
    {
        public static string ToLower(this Enum value)
        {
            return value.ToString().ToLower();
        }

        public static string ToJson(this object obj)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new SnakeCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new List<JsonConverter>()
                {
                    new NumericToStringConverter() 
                }
            };

            return JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
        }

        public static string ToSnakeCase(this Enum value)
        {
            return Regex.Replace(value.ToString(), @"(\w)([A-Z])", "$1_$2").ToLower();
        }

        public static string ToPascalCase(this string value)
        {
            return CultureInfo.InvariantCulture.TextInfo
                .ToTitleCase(value.Replace("_", " "))
                .Replace(" ", "");
        }
    }
}
