namespace TracklyApi.Models
{
    public class Asset
    {
        public Guid AssetID { get; set; }
        public string AssetName { get; set; }
        public string Category { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid LocationID { get; set; }

        // Navigation properties
        public virtual Department Department { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
