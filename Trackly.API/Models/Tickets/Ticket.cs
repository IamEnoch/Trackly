using TracklyApi.Models.Assets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Tickets
{
    public class Ticket
    {
        public Guid TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TicketStatus Status { get; set; }
        public Priority Priority { get; set; }
        public TicketCategory Category { get; set; }
        public string CreatedBy { get; set; }
        public string? AssignedUserId { get; set; }
        public Guid AssetId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? ClosedAt { get; set; }

        // Navigation properties
        public virtual Asset Asset { get; set; }
    }
}
