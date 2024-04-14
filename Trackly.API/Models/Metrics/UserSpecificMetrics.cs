public class UserSpecificMetrics
{
    public TechnicianMetrics TechnicianMetrics { get; set; }
    public AdminMetrics AdminMetrics { get; set; }

    public UserSpecificMetrics(TechnicianMetrics technicianMetrics, AdminMetrics adminMetrics)
    {
        TechnicianMetrics = technicianMetrics;
        AdminMetrics = adminMetrics;
    }
}