using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models
{
    public class Department
    {
        public Guid DepartmentID { get; set; }
        public DepartmentEnum DepartmentName { get; set; }

        //Navigation properties
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
