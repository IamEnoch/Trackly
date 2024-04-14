using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using TracklyApi.Models.Tickets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Assets
{
    public class Asset
    {
        public Guid AssetId { get; set; }
        // Ensures uniqueness
        public string BarcodeNumber { get; set; }
        public string AssetName { get; set; }
        public AssetCategory Category { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid LocationID { get; set; }
        public AssetCondition Condition { get; set; }
        public string? Ram { get; set; }
        public string SerialNumber { get; set; }
        public string? AssignedTo { get; set; }
        public string? Processor { get; set; }
        public string? Storage { get; set; }
        public string? Description { get; set; }
        public decimal PurchaseCost { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }



        // Navigation properties
        [JsonIgnore]
        public virtual Department Department { get; set; }
        [JsonIgnore]
        public virtual Location Location { get; set; }
        [JsonIgnore]
        public virtual ICollection<WorkItem> WorkItems { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
