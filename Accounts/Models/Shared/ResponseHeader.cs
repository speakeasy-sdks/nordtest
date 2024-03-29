
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
    using System;
    
    /// <summary>
    /// External response header
    /// </summary>
    public class ResponseHeader
    {

        /// <summary>
        /// Response creation time
        /// </summary>
        [JsonProperty("creation_date_time")]
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// HTTP code for response
        /// </summary>
        [JsonProperty("http_code")]
        public int? HttpCode { get; set; }

        /// <summary>
        /// Original request id for correlation purposes
        /// </summary>
        [JsonProperty("message_identification")]
        public string? MessageIdentification { get; set; }

        /// <summary>
        /// Details of paginated response
        /// </summary>
        [JsonProperty("message_pagination")]
        public Pagination? MessagePagination { get; set; }
    }
}