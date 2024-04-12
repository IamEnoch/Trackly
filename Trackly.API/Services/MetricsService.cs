using Microsoft.EntityFrameworkCore;
using Trackly.API.Interfaces;
using Trackly.API.Models;
using TracklyApi.Data;
using static TracklyApi.Helpers.EnumHelper;

namespace Trackly.API.Services
{
    public class MetricsService(AppDbContext _context) : IMetricsService
    {
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