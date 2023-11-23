
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
    using NodaTime;
    
    /// <summary>
    /// Transaction details
    /// </summary>
    public class Transaction
    {

        /// <summary>
        /// Negative amount indicates debit transaction
        /// </summary>
        [JsonProperty("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Balance after transaction. Exemption for Denmark: it can take up to 24 hours for the balance to be updated after a transaction is made. Exemption for Finland: not available.
        /// </summary>
        [JsonProperty("balance_after_transaction")]
        public double? BalanceAfterTransaction { get; set; }

        /// <summary>
        /// Date transaction was booked to the account ledger
        /// </summary>
        [JsonProperty("booking_date")]
        public LocalDate BookingDate { get; set; } = default!;

        /// <summary>
        /// 4 digits of card number of the transaction
        /// </summary>
        [JsonProperty("card_number")]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Counterparty account details
        /// </summary>
        [JsonProperty("counterparty_account")]
        public string? CounterpartyAccount { get; set; }

        /// <summary>
        /// Counterparty name
        /// </summary>
        [JsonProperty("counterparty_name")]
        public string? CounterpartyName { get; set; }

        /// <summary>
        /// Currency code according to ISO 4217
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Currency code according to ISO 4217
        /// </summary>
        [JsonProperty("currency_rate")]
        public double? CurrencyRate { get; set; }

        /// <summary>
        /// Message from remitter to beneficiary. In Finland this may alternatively include a short description of the transaction e.g. &apos;Automaattiotto&apos;
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Transaction narrative (customer custom message)
        /// </summary>
        [JsonProperty("narrative")]
        public string? Narrative { get; set; }

        /// <summary>
        /// Currency code according to ISO 4217
        /// </summary>
        [JsonProperty("original_currency")]
        public string? OriginalCurrency { get; set; }

        /// <summary>
        /// Foreign transaction amount in original currency
        /// </summary>
        [JsonProperty("original_currency_amount")]
        public double? OriginalCurrencyAmount { get; set; }

        /// <summary>
        /// Text message for the account holder&apos;s own use
        /// </summary>
        [JsonProperty("own_message")]
        public string? OwnMessage { get; set; }

        /// <summary>
        /// Payment date of the transaction
        /// </summary>
        [JsonProperty("payment_date")]
        public LocalDate? PaymentDate { get; set; }

        /// <summary>
        /// Reference number
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; set; }

        /// <summary>
        /// Status of the transaction
        /// </summary>
        [JsonProperty("status")]
        public TransactionStatus Status { get; set; } = default!;

        /// <summary>
        /// Date on which transaction was enacted
        /// </summary>
        [JsonProperty("transaction_date")]
        public LocalDate? TransactionDate { get; set; }

        /// <summary>
        /// Unique transaction identifier as defined by the bank. Exemption for Denmark: Transaction identifier changes when the transaction is finally booked. Exemption for Finland: If there are additional fees connected to a transaction then transaction and fees will have the same transaction_id
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// Description of the type of transaction, e.g. Cash withdrawal, Account transfer, etc. (localized)
        /// </summary>
        [JsonProperty("type_description")]
        public string? TypeDescription { get; set; }

        /// <summary>
        /// Value date of the transaction, used for interest calculation
        /// </summary>
        [JsonProperty("value_date")]
        public LocalDate? ValueDate { get; set; }
    }
}