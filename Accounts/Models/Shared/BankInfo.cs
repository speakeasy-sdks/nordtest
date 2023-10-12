
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
    
    /// <summary>
    /// Bank information
    /// </summary>
    public class BankInfo
    {

        /// <summary>
        /// Business Identifier Code of account servicing institution according to ISO 9362.
        /// </summary>
        [JsonProperty("bic")]
        public BankInfoBic Bic { get; set; } = default!;

        /// <summary>
        /// Country code according to ISO Alpha-2
        /// </summary>
        [JsonProperty("country")]
        public BankInfoCountry Country { get; set; } = default!;

        /// <summary>
        /// Nordea
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
    }
}