using Newtonsoft.Json;
using TracklyApi.Models.Assets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Tickets
{
    public class WorkItem
    {
        public Guid WorkItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public WorkItemStatus Status { get; set; }
        public Priority Priority { get; set; }
        public TicketCategory Category { get; set; }
        public Guid? CreatorUserID { get; set; }
        public Guid AssetId { get; set; }

        //Time created for the ticket
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        [JsonIgnore]    
        public virtual Asset Asset { get; set; }
    }
}
