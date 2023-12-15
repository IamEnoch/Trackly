namespace TracklyApi.Models
{
    public class Ticket
    {
        public Guid TicketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public Guid AssignedUserID { get; set; }
        public Guid AssetId { get; set; }

        // Navigation properties
        public virtual Asset Asset { get; set; }
    }
}
