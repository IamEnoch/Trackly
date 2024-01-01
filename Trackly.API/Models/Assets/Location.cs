using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Assets
{
    public class Location
    {
        public Guid LocationID { get; set; }
        public LocationEnum LocationName { get; set; }

        // Navigation properties
        public virtual ICollection<Asset> Assets { get; set; }

    }
}
