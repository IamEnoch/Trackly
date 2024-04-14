public class PercentageBreakdown
{
    public int GoodCondition { get; set; }
    public int UnderMaintenance { get; set; }

    public PercentageBreakdown(int goodCondition, int underMaintenance)
    {
        GoodCondition = goodCondition;
        UnderMaintenance = underMaintenance;
    }
}