
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Accounts.Models.Errors
{
    using Accounts.Models.Shared;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// Error response
    /// </summary>
    public class ErrorResponse : Exception
    {

        /// <summary>
        /// Error response body
        /// </summary>
        [JsonProperty("error")]
        public ErrorPayload? Error { get; set; }

        /// <summary>
        /// External response header
        /// </summary>
        [JsonProperty("group_header")]
        public ResponseHeader? GroupHeader { get; set; }
    }
}