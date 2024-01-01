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
        public Guid? AssignedUserID { get; set; }
        public Guid AssetID { get; set; }

        //Time created for the ticket
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public virtual Asset Asset { get; set; }
    }
}
