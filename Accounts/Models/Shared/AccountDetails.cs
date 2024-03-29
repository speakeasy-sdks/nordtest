
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
    using NodaTime;
    using System.Collections.Generic;
    
    /// <summary>
    /// Detailed account information
    /// </summary>
    public class AccountDetails
    {

        /// <summary>
        /// Internal, technical account identifier
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// HATEOAS inspired links: &apos;rel&apos; and &apos;href&apos;
        /// </summary>
        [JsonProperty("_links")]
        public List<Link>? Links { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("account_name")]
        public string AccountName { get; set; } = default!;

        /// <summary>
        /// Account numbers
        /// </summary>
        [JsonProperty("account_numbers")]
        public List<AccountNumber> AccountNumbers { get; set; } = default!;

        /// <summary>
        /// Account type
        /// </summary>
        [JsonProperty("account_type")]
        public AccountType AccountType { get; set; } = default!;

        /// <summary>
        /// Available balance indicates the funds which are available to the account holder at the time of the query
        /// </summary>
        [JsonProperty("available_balance")]
        public double AvailableBalance { get; set; } = default!;

        /// <summary>
        /// Bank information
        /// </summary>
        [JsonProperty("bank")]
        public BankInfo Bank { get; set; } = default!;

        /// <summary>
        /// Booked balance includes all transactions entered on the account at the time of the query
        /// </summary>
        [JsonProperty("booked_balance")]
        public double BookedBalance { get; set; } = default!;

        /// <summary>
        /// Country code where the account is held according to ISO ALPHA-2
        /// </summary>
        [JsonProperty("country")]
        public Country Country { get; set; } = default!;

        /// <summary>
        /// Amount of credit extended to account holder beyond account booked balance
        /// </summary>
        [JsonProperty("credit_limit")]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// Currency code according to ISO 4217
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Date of last transaction booked to the account
        /// </summary>
        [JsonProperty("latest_transaction_booking_date")]
        public LocalDate? LatestTransactionBookingDate { get; set; }

        /// <summary>
        /// The nickname of the account set by the customer
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// Name of the banking product delivered by this account
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; } = default!;

        /// <summary>
        /// Status of account
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; } = default!;

        /// <summary>
        /// Value dated balance is the balance on the basis of which interest is calculated on the account
        /// </summary>
        [JsonProperty("value_dated_balance")]
        public double? ValueDatedBalance { get; set; }
    }
}