using Microsoft.EntityFrameworkCore;
using Trackly.API.Interfaces;
using Trackly.API.Models.Metrics;
using TracklyApi.Data;
using static TracklyApi.Helpers.EnumHelper;

namespace Trackly.API.Services
{

    public class MetricsService : IMetricsService
    {
        private readonly AppDbContext _context;
        public MetricsService(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get metrics for the report to be generated
        /// </summary>
        /// <returns>Metrics for the report(Pdf)</returns>
        // public async Task<PdfMetrics> GetPdfMetricsAsync(){
        //     var assetQuery = _context.Assets;
        //     var ticketQuery = _context.Tickets;
        //     var workItemQuery = _context.WorkItems;

        //     var assetsUnderMaintenance = await assetQuery
        //         .CountAsync(a => a.Tickets.Any(t => t.Status != TicketStatus.Completed && t.Status != TicketStatus.Closed));
        //     var totalAssets = await assetQuery.CountAsync();
        //     var totalTickets = await ticketQuery.CountAsync();
        //     var totalWorkItems = await workItemQuery.CountAsync();

        //     var conditionCounts = await assetQuery
        //         .GroupBy(a => a.Condition)
        //         .Select(g => new { Condition = g.Key, Count = g.Count() })
        //         .ToDictionaryAsync(x => x.Condition, x => x.Count);

        //     var statusCounts = await ticketQuery
        //         .GroupBy(t => t.Status)
        //         .Select(g => new { Status = g.Key, Count = g.Count() })
        //         .ToDictionaryAsync(x => x.Status, x => x.Count);

        //     var workItemStatusCounts = await workItemQuery
        //         .GroupBy(w => w.Status)
        //         .Select(g => new { Status = g.Key, Count = g.Count() })
        //         .ToDictionaryAsync(x => x.Status, x => x.Count);

        //     var assetsCondtitionMetrics = new AssetsConditionMetrics
        //     {
        //         New = conditionCounts.GetValueOrDefault(AssetCondition.New, 0),
        //         Good = conditionCounts.GetValueOrDefault(AssetCondition.Good, 0),
        //         Fair = conditionCounts.GetValueOrDefault(AssetCondition.Fair, 0),
        //         Broken = conditionCounts.GetValueOrDefault(AssetCondition.Broken, 0),
        //         Poor = conditionCounts.GetValueOrDefault(AssetCondition.Poor, 0)
        //     };

        //     var ticketsStatusMetrics = new TicketsStatusMetrics
        //     {
        //         Open = statusCounts.GetValueOrDefault(TicketStatus.Open, 0),
        //         InProgress = statusCounts.GetValueOrDefault(TicketStatus.InProgress, 0),
        //         Completed = statusCounts.GetValueOrDefault(TicketStatus.Completed, 0),
        //         Closed = statusCounts.GetValueOrDefault(TicketStatus.Closed, 0)
        //     };

        //     var workItemStatusMetrics = new WorkItemStatusMetrics(
        //         workItemStatusCounts.GetValueOrDefault(WorkItemStatus.Pending, 0),
        //         workItemStatusCounts.GetValueOrDefault(WorkItemStatus.Approved, 0),
        //         workItemStatusCounts.GetValueOrDefault(WorkItemStatus.Rejected, 0)
        //     );

        //     var assetsNotUnderMaintenance = totalAssets - assetsUnderMaintenance;

        //     var assetMaintenanceMetrics = new AssetMaintenanceMetrics(
        //         new PercentageBreakdown(
        //             assetsUnderMaintenance,
        //             assetsNotUnderMaintenance
        //         )
        //     );

        //     var workItemTicketMetrics = new WorkItemTicketMetrics(
        //         workItemStatusMetrics,
        //         // Calculate approval rate
        //         (int)Math.Round(
        //             (double)workItemStatusCounts.GetValueOrDefault(WorkItemStatus.Approved, 0) / totalWorkItems * 100
        //         ),
        //         // Calculate rejection rate
        //         (int)Math.Round(
        //             (double)workItemStatusCounts.GetValueOrDefault(WorkItemStatus.Rejected, 0) / totalWorkItems * 100
        //         ),
        //         // Calculate ticket closure rate
        //         (int)Math.Round(
        //             (double)statusCounts.GetValueOrDefault(TicketStatus.Closed, 0) / totalTickets * 100
        //         )
        //     );

        //     //No users table but we have user id in tickets table. Cannot differentiate between technician and admin
        //     var userSpecificMetrics = new UserSpecificMetrics(


        //     );

        //     var locationDepartmentInfo = await _context.Locations
        //         .Include(l => l.LocationID)
        //         .Select(l => new LocationDepartmentInfo
        //         {
        //             Location = l.Name,
        //             Departments = l.Departments.Select(d => d.Name).ToList()
        //         })
        //         .ToListAsync();
                
        // }


        /// <summary>
        /// Get metrics for the dashboard
        /// </summary>
        /// <returns>Metrics for the dashboard</returns>                                
        public async Task<Metrics> GetMetricsAsync()
        {
            var assetQuery = _context.Assets;
            var ticketQuery = _context.Tickets;

            var assetsUnderMaintenance = await assetQuery
                .CountAsync(a => a.Tickets.Any(t => t.Status != TicketStatus.Completed && t.Status != TicketStatus.Closed));
            var totalAssets = await assetQuery.CountAsync();
            var totalTickets = await ticketQuery.CountAsync();

            var conditionCounts = await assetQuery
                .GroupBy(a => a.Condition)
                .Select(g => new { Condition = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.Condition, x => x.Count);

            var statusCounts = await ticketQuery
                .GroupBy(t => t.Status)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.Status, x => x.Count);

            var assetsCondtitionMetrics = new AssetsConditionMetrics
            {
                New = conditionCounts.GetValueOrDefault(AssetCondition.New, 0),
                Good = conditionCounts.GetValueOrDefault(AssetCondition.Good, 0),
                Fair = conditionCounts.GetValueOrDefault(AssetCondition.Fair, 0),
                Broken = conditionCounts.GetValueOrDefault(AssetCondition.Broken, 0),
                Poor = conditionCounts.GetValueOrDefault(AssetCondition.Poor, 0)
            };

            var ticketsStatusMetrics = new TicketsStatusMetrics
            {
                Open = statusCounts.GetValueOrDefault(TicketStatus.Open, 0),
                InProgress = statusCounts.GetValueOrDefault(TicketStatus.InProgress, 0),
                Completed = statusCounts.GetValueOrDefault(TicketStatus.Completed, 0),
                Closed = statusCounts.GetValueOrDefault(TicketStatus.Closed, 0)
            };

            var assetsNotUnderMaintenance = totalAssets - assetsUnderMaintenance;

            return new Metrics
            {
                TotalAssets = totalAssets,
                AssetsUnderMaintenance = assetsUnderMaintenance,
                AssetsNotUnderMaintenance = assetsNotUnderMaintenance,
                TotalTickets = totalTickets,
                AssetsConditionMetrics = assetsCondtitionMetrics,
                TicketsStatusMetrics = ticketsStatusMetrics
            };

        }

    }
}