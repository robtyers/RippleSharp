using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RippleSharp.Rippled.Interfaces;

namespace RippleSharp.Rippled.Json
{
    public class SnakeCasePropertyNamesContractResolver : DefaultContractResolver
    {
        private bool _ignore;

        protected override JsonConverter ResolveContractConverter(Type objectType)
        {
            _ignore = (typeof(IDefaultResolver).IsAssignableFrom(objectType));
            return base.ResolveContractConverter(objectType);

        }

        protected override string ResolvePropertyName(string propertyName)
        {
            // https://migara.li/2016/01/09/json-net-easy-serialization/
            return _ignore 
                ? propertyName 
                : Regex.Replace(propertyName, @"(\w)([A-Z])", "$1_$2").ToLower();
        }
    }
}
