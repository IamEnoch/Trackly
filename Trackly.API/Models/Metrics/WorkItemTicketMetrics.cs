public  class WorkItemTicketMetrics
{
    public WorkItemStatusMetrics WorkItemStatus { get; set; }
    public int ApprovalRate { get; set; }
    public int RejectionRate { get; set; }
    public int TicketClosureRate { get; set; }

    public WorkItemTicketMetrics(WorkItemStatusMetrics workItemStatus,int approvalRate, int rejectionRate, int ticketClosureRate)
    {
        WorkItemStatus = workItemStatus;
        ApprovalRate = approvalRate;
        RejectionRate = rejectionRate;
        TicketClosureRate = ticketClosureRate;
    }
}