using TracklyApi.Models.Tickets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs
{
    public class AssetResponseDto
    {
        public string BarcodeNumber { get; set; }
        public string AssetName { get; set; }
        public string Category { get; set; }
        public string DepartmentName { get; set; }
        public string LocationName { get; set; }
        public IList<TicketDto>? Tickets { get; set; }

        public AssetResponseDto(string barcodeNumber, string assetName, AssetCategory category, DepartmentEnum departmentName, LocationEnum locationName, ICollection<Ticket> tickets)
        {
            BarcodeNumber = barcodeNumber;
            AssetName = assetName;
            Category = category.ToString();
            DepartmentName = departmentName.ToString();
            LocationName = locationName.ToString();
            Tickets = tickets.Select(t => new TicketDto(t.Title, t.Description, t.Status, t.Priority, t.Category, t.AssignedUserID, t.CreatedAt))
                .ToList();
        }
    }
}
