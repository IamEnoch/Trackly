public class LocationDepartmentInfo
{
    public string Location { get; set; }
    public string Department { get; set; }
    public AssetsMetrics AssetMetrics { get; set; }

    public LocationDepartmentInfo(string location, string department, AssetsMetrics assetMetrics)
    {
        Location = location;
        Department = department;
        AssetMetrics = assetMetrics;
    }
}