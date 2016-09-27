using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Interfaces;
using RippleSharp.Rippled.Models.Shared;
using RippleSharp.Rippled.Models.Shared.LedgerNode;
using RippleSharp.Rippled.Models.Shared.Server;

namespace RippleSharp.Rippled.Json
{
    public class LedgerNodeConverter : Newtonsoft.Json.Converters.CustomCreationConverter<ILedgerNode>
    {
        // http://stackoverflow.com/questions/12832306/net-deserializing-json-to-multiple-types

        public override ILedgerNode Create(Type objectType)
        {
            throw new NotImplementedException();
        }

        public ILedgerNode Create(Type objectType, JObject jObject)
        {
            var type = (string)jObject.Property(nameof(LedgerEntryType));

            switch (type)
            {
                case LedgerEntryType.AccountRoot:
                    return new AccountRoot();

                case LedgerEntryType.DirectoryNode:
                    return new DirectoryNode();

                case LedgerEntryType.Offer:
                    return new Offer();

                case LedgerEntryType.RippleState:
                    return new RippleState();

                case LedgerEntryType.SignerList:
                    return new SignerList();

                default:
                    throw new ApplicationException($"The {nameof(LedgerEntryType)} {type} is not supported!");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var target = Create(objectType, jObject);
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }
    }

    public class CurrencyAmountConverter : Newtonsoft.Json.Converters.CustomCreationConverter<IAmount>
    {
        // http://stackoverflow.com/questions/12832306/net-deserializing-json-to-multiple-types

        public override IAmount Create(Type objectType)
        {
            throw new NotImplementedException();
        }

        public dynamic Create(Type objectType, JObject jObject)
        {
            if(jObject["amount"] != null)
                return new CurrencyIssuerAmount();

            if (jObject["value"] != null)
                return new CurrencyIssuerValue();
            
            return new object(); 
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // http://stackoverflow.com/questions/6416017/json-net-deserializing-nested-dictionaries
            
            if (reader.TokenType == JsonToken.StartObject || reader.TokenType == JsonToken.Null)
            {
                var jObject = JObject.Load(reader);
                var target = Create(objectType, jObject);
                serializer.Populate(jObject.CreateReader(), target);

                return target;
            }
            
            return new CurrencyIssuerValue()
            {
                Currency = "XRP",
                Issuer = string.Empty,
                Value = float.Parse(reader.Value.ToString())
            };
        }
    }

    public class JobTypeConverter : Newtonsoft.Json.Converters.CustomCreationConverter<IJobType>
    {
        // http://stackoverflow.com/questions/12832306/net-deserializing-json-to-multiple-types

        public override IJobType Create(Type objectType)
        {
            throw new NotImplementedException();
        }

        public IJobType Create(Type objectType, JObject jObject)
        {
            var type = (string) jObject.Property(nameof(JobType));

            switch (type.ToLowerInvariant())
            {
                case JobType.ClientCommand:
                    return new JobTypeInProgress();

                case JobType.PeerCommand:
                case JobType.TrustedProposal:
                case JobType.UntrustedProposal:
                case JobType.WriteNode:
                case JobType.WriteObjects:
                    return new JobTypePerSecond();

                default:
                    throw new ApplicationException($"The {nameof(JobType)} {type} is not supported!");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var target = Create(objectType, jObject);
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }
    }

    public class TolerantEnumConverter : JsonConverter
    {
        // http://stackoverflow.com/questions/22752075/how-can-i-ignore-unknown-enum-values-during-json-deserialization

        public override bool CanConvert(Type objectType)
        {
            var type = IsNullableType(objectType) ? Nullable.GetUnderlyingType(objectType) : objectType;
            return type.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var isNullable = IsNullableType(objectType);
            var enumType = isNullable ? Nullable.GetUnderlyingType(objectType) : objectType;
            var names = Enum.GetNames(enumType);

            switch (reader.TokenType)
            {
                case JsonToken.String:
                    var enumText = reader.Value.ToString();

                    if (!string.IsNullOrEmpty(enumText))
                    {
                        var match = names
                            .FirstOrDefault(n => string.Equals(n, enumText, StringComparison.OrdinalIgnoreCase));

                        if (match != null)
                            return Enum.Parse(enumType, match);
                    }
                    break;

                case JsonToken.Integer:
                    var enumVal = Convert.ToInt32(reader.Value);
                    var values = (int[]) Enum.GetValues(enumType);
                    if (values.Contains(enumVal))
                        return Enum.Parse(enumType, enumVal.ToString());
                    break;
            }

            if (isNullable)
                return null;

            var defaultName = names.FirstOrDefault(n => 
                string.Equals(n, "Unknown", StringComparison.OrdinalIgnoreCase)) ?? names.First();

            return Enum.Parse(enumType, defaultName);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        private static bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
}
