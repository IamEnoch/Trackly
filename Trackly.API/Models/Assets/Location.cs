using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Assets
{
    public class Location
    {
        public Guid LocationID { get; set; }
        public LocationEnum LocationName { get; set; }

        // Navigation properties
        public virtual ICollection<Department> Departments { get; set; } // Location can have multiple departments
        public virtual ICollection<Asset> Assets { get; set; }

    }
}
