using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;

namespace VindiSharp.Core.Entities
{
    public class ChargeSummary
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("status")]
        public ChargeStatus Status { get; set; }

        [JsonProperty("due_at")]
        public DateTimeOffset DueAt { get; set; }

        [JsonProperty("paid_at")]
        public DateTimeOffset? PaidAt { get; set; }

        [JsonProperty("installments")]
        public int Installments { get; set; }

        [JsonProperty("attempt_count")]
        public int AttemptCount { get; set; }

        [JsonProperty("next_attempt")]
        public int NextAttempt { get; set; }

        [JsonProperty("print_url")]
        public string PrintUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("last_transaction")]
        public TransactionSummary LastTransaction { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }
    }
}
