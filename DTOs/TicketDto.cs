using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs
{
    public class TicketDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Category { get; set; }
        public string? AssignedUser { get; set; }

        public TicketDto(string title, string description, TicketStatus status, Priority priority, TicketCategory category, Guid? assignedUserID)
        {
            Title = title;
            Description = description;
            Status = status.ToString();
            Priority = priority.ToString();
            Category = category.ToString();
            AssignedUser = assignedUserID.ToString();            
        }
    }
}
