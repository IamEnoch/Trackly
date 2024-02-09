using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs.Input
{
    public class AssetRequestUpdateDto
    {
        public string? BarcodeNumber { get; set; }
        public string? AssetName { get; set; }
        public string? Category { get; set; }
        public string? Department { get; set; }
        public string? Location { get; set; }
        public string? Condition { get; set; }
        public string? Ram { get; set; }
        public string? SerialNumber { get; set; }
        public string? AssignedToId { get; set; }
        public string? Processor { get; set; }
        public string? Storage { get; set; }
        public string? Description { get; set; }
        public string? PurchaseCost { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
