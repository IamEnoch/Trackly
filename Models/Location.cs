namespace TracklyApi.Models
{
    public class Location
    {
        public Guid LocationID { get; set; }
        public string LocationName { get; set; }

        // Navigation properties
        public virtual ICollection<Asset> Assets { get; set; }

    }
}
