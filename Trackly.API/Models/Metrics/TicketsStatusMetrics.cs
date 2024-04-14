namespace Trackly.API.Models.Metrics;
public class TicketsStatusMetrics
{    
    public int Open { get; set; }
    public int InProgress { get; set; }
    public int Completed { get; set; }
    public int Closed { get; set; }
}