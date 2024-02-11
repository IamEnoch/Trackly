using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.DTOs.Input
{
    public class AssetRequestCreateDto
    {
        //Properties to match the asset model
        public string BarcodeNumber { get; set; }
        public string AssetName { get; set; }
        public string Category { get; set; }
        public string DepartmentName { get; set; }
        public string LocationName { get; set; }
        public string SerialNumber { get; set; }
        public string? Description { get; set; }
        public string Condition { get; set; }
        public string? Ram { get; set; }
        public string AssignedTo { get; set; }
        public string? Processor { get; set; }
        public string? Storage { get; set; }
        public decimal PurchaseCost { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
