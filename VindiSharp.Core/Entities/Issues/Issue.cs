using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;

namespace VindiSharp.Core.Entities
{
    public class Issue
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("issue_type")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public IssueType IssueType { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
        public IssueStatus Status { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("customer")]
        public CustomerSummary Customer { get; set; }
    }
}
