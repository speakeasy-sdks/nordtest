
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
    /// Account list response
    /// </summary>
    public class AccountListResponse
    {

        /// <summary>
        /// External response header
        /// </summary>
        [JsonProperty("group_header")]
        public ResponseHeader? GroupHeader { get; set; }

        /// <summary>
        /// List of accounts
        /// </summary>
        [JsonProperty("response")]
        public AccountList? Response { get; set; }
    }
}