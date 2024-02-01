using TracklyApi.Models.Tickets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs.Output
{
    public class AssetResponseDto(string barcodeNumber, Guid assetId, string assetName,
        AssetCategory category, DepartmentEnum departmentName, LocationEnum locationName,
        string? description, DateTime createdAt, DateTime? updatedAt, DateTime? deletedAt,
        DateTime purchaseDate, decimal purchaseCost, string? storage, string? processor,
        string serialNumber, string? ram, string? assignedTo, AssetCondition condition,
        ICollection<Ticket> tickets)
    {
        public string BarcodeNumber { get; set; } = barcodeNumber;
        public string AssetId { get; set; } = assetId.ToString();
        public string AssetName { get; set; } = assetName;
        public string Category { get; set; } = category.ToString();
        public string DepartmentName { get; set; } = departmentName.ToString();
        public string LocationName { get; set; } = locationName.ToString();
        public string Description { get; set; } = description;
        public string CreatedAt { get; set; } = createdAt.ToString("yyyy-MM-dd");
        public string UpdatedAt { get; set; } = updatedAt?.ToString("yyyy-MM-dd");
        public string DeletedAt { get; set; } = deletedAt?.ToString("yyyy-MM-dd");
        public string PurchaseDate { get; set; } = purchaseDate.ToString("yyyy-MM-dd");
        public string PurchaseCost { get; set; } = purchaseCost.ToString();
        public string Storage { get; set; } = storage;
        public string Processor { get; set; } = processor;
        public string SerialNumber { get; set; } = serialNumber;
        public string Ram { get; set; } = ram;
        public string AssignedTo { get; set; } = assignedTo;
        public string Condition { get; set; } = condition.ToString();

        public IList<TicketDto>? Tickets { get; set; } = tickets.Select(t => new TicketDto(t.Title, t.Description, t.Status, t.Priority, t.Category, t.AssignedUserID, t.CreatedAt, t.CompletedAt, t.ClosedAt))
                .ToList();
    }
}
