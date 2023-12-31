
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Accounts.Models.Operations
{
    using Accounts.Utils;
    using NodaTime;
    
    public class TransactionListUsingGETRequest
    {

        /// <summary>
        /// A signature of request by the TPP on application level. The process of signing a request is described in &apos;Signing HTTP Messages&apos; RFC draft version 10 (&lt;a href=&quot;https://tools.ietf.org/html/draft-cavage-http-signatures-10&quot; target=&quot;_blank&quot;&gt;https://tools.ietf.org/html/draft-cavage-http-signatures-10&lt;/a&gt;). The request signature needs to be sent in the &apos;Signature&apos; HTTP header as described in the RFC. Additional requirements from Nordea <br/>
        /// 
        /// <remarks>
        ///  - The only allowed algorithm is RSA-SHA256 <br/>
        /// - The key size for the used RSA key pair has to be at least 2048 bit <br/>
        /// - The keyId is the clientId of your application originating from the Nordea Developer Portal <br/>
        /// - We require the following headers to be used in the signature <br/>
        /// * Request without body: (request-target) X-Nordea-Originating-Host X-Nordea-Originating-Date <br/>
        /// * Request with body: (request-target) X-Nordea-Originating-Host X-Nordea-Originating-Date Content-type Digest <br/>
        /// * The request-target is a combination of the HTTP action verb and the request URI path
        /// </remarks>
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=Signature")]
        public string Signature { get; set; } = default!;

        /// <summary>
        /// Id of the Client
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-IBM-Client-Id")]
        public string XIBMClientId { get; set; } = default!;

        /// <summary>
        /// Secret password generated for the Client
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-IBM-Client-Secret")]
        public string XIBMClientSecret { get; set; } = default!;

        /// <summary>
        /// HTTP header element for date and time represented as RFC 7231 Full Dates (GMT). Example date: **Wed, 24 Apr 2019 14:00:37 GMT**. It is similar to standard HTTP &apos;Date&apos; expect that it allows to set it under JavaScript in browser while standard &apos;Date&apos; is forbidden
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Nordea-Originating-Date")]
        public string XNordeaOriginatingDate { get; set; } = default!;

        /// <summary>
        /// HTTP header element for specification of the domain name of the server. It is similar to standard HTTP &apos;Host&apos; header but it won&apos;t be overridden by proxies. It also allows to set it under JavaScript in browser while standard &apos;Host&apos; is forbidden
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Nordea-Originating-Host")]
        public string XNordeaOriginatingHost { get; set; } = default!;

        /// <summary>
        /// End user (i.e. PSU) agent information, to be provided if TPP is in session with the PSU
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Nordea-Originating-User-Agent")]
        public string? XNordeaOriginatingUserAgent { get; set; }

        /// <summary>
        /// End user (i.e. PSU) IP address, to be provided if TPP is in session with the PSU
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=X-Nordea-Originating-User-Ip")]
        public string? XNordeaOriginatingUserIp { get; set; }

        /// <summary>
        /// Resource listing may return a continuationKey if there&apos;s more results available. Request may be retried with the continuationKey, but otherwise same parameters, in order to get more results.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=continuation_key")]
        public string? ContinuationKey { get; set; }

        /// <summary>
        /// List transactions starting from and including this date
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=from_date")]
        public LocalDate? FromDate { get; set; }

        /// <summary>
        /// Internal, technical account identifier
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Preferred language for textual values, possible values are: fi, sv, en, da
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=language")]
        public string? Language { get; set; }

        /// <summary>
        /// List transactions until and including this date
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=to_date")]
        public LocalDate? ToDate { get; set; }
    }
}