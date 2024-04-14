public class TechnicianMetrics
{
    public TicketCompletionRate WorkloadDistribution { get; set; }
    public TicketCompletionRate TicketCompletionRate { get; set; }
    public AverageTime AverageTicketCompletionTime { get; set; }
    public AverageTime AverageResponseTime { get; set; }

    public TechnicianMetrics(TicketCompletionRate workloadDistribution, TicketCompletionRate ticketCompletionRate, AverageTime averageTicketCompletionTime, AverageTime averageResponseTime)
    {
        WorkloadDistribution = workloadDistribution;
        TicketCompletionRate = ticketCompletionRate;
        AverageTicketCompletionTime = averageTicketCompletionTime;
        AverageResponseTime = averageResponseTime;
    }
}