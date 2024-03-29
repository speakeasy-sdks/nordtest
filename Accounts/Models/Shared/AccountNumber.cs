
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
    using Accounts.Models.Shared;
    using Newtonsoft.Json;
    
    /// <summary>
    /// Account number
    /// </summary>
    public class AccountNumber
    {

        /// <summary>
        /// Type of account number
        /// </summary>
        [JsonProperty("_type")]
        public Type Type { get; set; } = default!;

        /// <summary>
        /// Actual account number
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; } = default!;
    }
}