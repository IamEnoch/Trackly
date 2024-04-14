using System.ComponentModel.DataAnnotations.Schema;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Assets
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public DepartmentEnum DepartmentName { get; set; }
        
        [ForeignKey("Location")]
        public Guid LocationID { get; set; }

        //Navigation properties
        public virtual Location Location { get; set; } // Department belongs to a location
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
