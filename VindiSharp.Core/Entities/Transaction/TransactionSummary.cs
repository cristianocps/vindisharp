using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;

namespace VindiSharp.Core.Entities
{
    public class TransactionSummary
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionType TransactionType { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionStatus Status { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("installments")]
        public int Installments { get; set; }

        [JsonProperty("gateway_message")]
        public string GatewayMessage { get; set; }

        [JsonProperty("gateway_response_code")]
        public string GatewayResponseCode { get; set; }

        [JsonProperty("gateway_authorization")]
        public string GatewayAuthorization { get; set; }

        [JsonProperty("gateway_transaction_id")]
        public string GatewayTransactionId { get; set; }

        [JsonProperty("gateway_response_fields")]
        public string GatewayResponseFields { get; set; }

        [JsonProperty("fraud_detector_score")]
        public int FraudDetectorScore { get; set; }

        [JsonProperty("fraud_detector_status")]
        public string FraudDetectorStatus { get; set; }

        [JsonProperty("fraud_detector_id")]
        public string FraudDetectorId { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("payment_profile")]
        public PaymentProfile PaymentProfile { get; set; }
    }
}
