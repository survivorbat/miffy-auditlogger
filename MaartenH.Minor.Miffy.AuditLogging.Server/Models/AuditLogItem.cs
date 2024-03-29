using System.Diagnostics.CodeAnalysis;

namespace MaartenH.Minor.Miffy.AuditLogging.Server.Models
{
    /// <summary>
    /// Shape of an auditlog item, based on the properties of a DomainEvent
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class AuditLogItem
    {
        public string Id { get; set; }
        public string Topic { get; set; }
        public long TimeStamp { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
    }
}
