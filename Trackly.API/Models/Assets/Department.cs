using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Models.Assets
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public DepartmentEnum DepartmentName { get; set; }

        //Navigation properties
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
