public class WorkItemStatusMetrics
{
    public int Pending { get; set; }
    public int Approved { get; set; }
    public int Rejected { get; set; }
    public WorkItemStatusMetrics(int pending, int approved, int rejected)
    {
        Pending = pending;
        Approved = approved;
        Rejected = rejected;
    }
}