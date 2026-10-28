namespace ECommerceConsoleApp.Models
{
    public class AuditLog
    {
        public int AuditLogId { get; set; }

        public string EntityName { get; set; } = string.Empty;

        public int? EntityId { get; set; }

        public string Action { get; set; } = string.Empty;

        public string? Details { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}