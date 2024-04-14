using TracklyApi.Models.Tickets;

public class PdfMetrics
{
    public AssetMaintenanceMetrics AssetMaintenanceMetrics { get; set; }
    public WorkItemTicketMetrics WorkItemTicketMetrics { get; set; }
    public UserSpecificMetrics UserSpecificMetrics { get; set; }
    public List<LocationDepartmentInfo> LocationDepartmentInfo { get; set; }

    public PdfMetrics(AssetMaintenanceMetrics assetMaintenanceMetrics, WorkItemTicketMetrics workItemTicketMetrics, UserSpecificMetrics userSpecificMetrics, List<LocationDepartmentInfo> locationDepartmentInfo)
    {
        AssetMaintenanceMetrics = assetMaintenanceMetrics;
        WorkItemTicketMetrics = workItemTicketMetrics;
        UserSpecificMetrics = userSpecificMetrics;
        LocationDepartmentInfo = locationDepartmentInfo;
    }
}