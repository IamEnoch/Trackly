public class AssetMaintenanceMetrics
{
    public PercentageBreakdown PercentageBreakdown { get; set; }

    public AssetMaintenanceMetrics(PercentageBreakdown percentageBreakdown)
    {
        PercentageBreakdown = percentageBreakdown;
    }
    
}