namespace TracklyApi.DTOs.RequestDTOs
{
    public class WorkItemRequestDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; } // TODO: Change to enum
        public string Status { get; set; } // TODO: Change to enum
        public string Category { get; set; } // TODO: Change to enum
        public string AssetId { get; set; }
    }
}
