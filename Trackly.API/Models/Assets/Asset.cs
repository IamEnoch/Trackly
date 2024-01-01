using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TracklyApi.Models.Tickets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Assets
{
    public class Asset
    {
        public Guid AssetID { get; set; }

        // Ensures uniqueness
        public string BarcodeNumber { get; set; }
        public string AssetName { get; set; }
        public AssetCategory Category { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid LocationID { get; set; }

        // Navigation properties
        public virtual Department Department { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<WorkItem> WorkItems { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
