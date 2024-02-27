using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs.Output
{
    public class WorkItemResponseDto
    {
        public String WorkItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public WorkItemStatus Status { get; set; }
        public Priority Priority { get; set; }
        public TicketCategory Category { get; set; }
        public string CreatorUserId { get; set; }
        public Guid AssetId { get; set; }
        
        //Time created for the ticket
        public DateTime CreatedAt { get; set; }
    }
}
