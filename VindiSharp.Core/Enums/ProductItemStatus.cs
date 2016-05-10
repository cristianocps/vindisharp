using System.Runtime.Serialization;

namespace VindiSharp.Core.Entities
{
    public enum ProductItemStatus
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "deleted")]
        Deleted
    }
}