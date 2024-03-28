
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Accounts.Utils
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;

    public class AnyDeserializer : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Dictionary<string, object>));
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object? existingValue,
            JsonSerializer serializer
        )
        {
            return ParseTokenIntoDictionary(JToken.Load(reader));
        }

        private Dictionary<string, object?> ParseTokenIntoDictionary(JToken token)
        {
            var dict = new Dictionary<string, object?>();

            foreach (var child in token.Children<JProperty>())
            {

                object? val = null;
                if (child.Value is JObject)
                {
                    val = ParseTokenIntoDictionary(child.Value);
                }
                else if (child.Value is JArray)
                {
                    val = ParseTokenIntoList(child.Value);
                }
                else if (child.Value != null)
                {
                    val = ((JValue)child.Value).Value;
                }

                dict[child.Name] = val;
            }

            return dict;
        }

        private List<object?> ParseTokenIntoList(JToken token)
        {
            var list = new List<object?>();

            foreach (var child in token.Children())
            {
                if (child is JObject)
                {
                    list.Add((object)ParseTokenIntoDictionary(child));
                }
                else if (child is JArray)
                {
                    list.Add((object)ParseTokenIntoList(child));
                }
                else
                {
                    list.Add(((JValue)child).Value);
                }
            }

            return list;
        }
    }
}