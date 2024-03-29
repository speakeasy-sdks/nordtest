
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Accounts.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Business Identifier Code of account servicing institution according to ISO 9362.
    /// </summary>
    public enum Bic
    {
        [JsonProperty("NDEAFIHH")]
        Ndeafihh,
        [JsonProperty("NDEASESS")]
        Ndeasess,
        [JsonProperty("NDEADKKK")]
        Ndeadkkk,
        [JsonProperty("NDEANOKK")]
        Ndeanokk,
    }

    public static class BicExtension
    {
        public static string Value(this Bic value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Bic ToEnum(this string value)
        {
            foreach(var field in typeof(Bic).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is Bic)
                    {
                        return (Bic)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Bic");
        }
    }

}