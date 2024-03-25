using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs
{
    public class TicketDto
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public string Category { get; set; }
        public string? AssignedUser { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public DateTime? ClosedAt { get; set; }


        public TicketDto(Guid id, string title, string description, TicketStatus status, Priority priority, TicketCategory category, string? assignedUserID, DateTime createdAt, DateTime? completedAt, DateTime? closedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status.ToString();
            Priority = priority.ToString();
            Category = category.ToString();
            AssignedUser = assignedUserID.ToString();
            CreatedAt = createdAt;
            CompletedAt = completedAt;
            ClosedAt = closedAt;
        }
    }
}
