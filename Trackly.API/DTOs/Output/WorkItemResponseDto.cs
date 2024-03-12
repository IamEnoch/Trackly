using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs.Output
{
    public class WorkItemResponseDto(string workItemId, string title, string description, string status, 
        Priority priority, TicketCategory category, string creatorUserId, Guid assertId, DateTime createdDate)
    {

        public string WorkItemId { get; set; } = workItemId;
        public string Title { get; set; } = title;
        public string Description { get; set; } = description;
        public string Status { get; set; } = status;
        public string Priority { get; set; } = priority.ToString();
        public string Category { get; set; } = category.ToString();
        public string CreatorUserID { get; set; } = creatorUserId;
        public string AssetId { get; set; } = assertId.ToString();
        
        //Time created for the ticket
        public DateTime CreatedAt { get; set; } = createdDate;
    }
}
