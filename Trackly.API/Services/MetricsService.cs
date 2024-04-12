using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //asset under maintenance if a ticket has been created for it and not completed or closed
            var assetsUnderMaintenance =  await _context.Assets
                .Where(a => a.Tickets.Any(t => t.Status != TicketStatus.Completed && t.Status != TicketStatus.Closed))
                .CountAsync();
            var totalAssets = await _context.Assets.CountAsync();
            var assetsNotUnderMaintenance = totalAssets - assetsUnderMaintenance;
            var totalTickets = await _context.Tickets.CountAsync();

            //Get the numbers for the different asset condition(Fair, good, poor, broken)
            var assetsCondtitionMetrics = new AssetsConditionMetrics
            {
                New = await _context.Assets.Where(a => a.Condition == AssetCondition.New).CountAsync(),
                Good = await _context.Assets.Where(a => a.Condition == AssetCondition.Good).CountAsync(),
                Fair = await _context.Assets.Where(a => a.Condition == AssetCondition.Fair).CountAsync(),
                Broken = await _context.Assets.Where(a => a.Condition == AssetCondition.Broken).CountAsync(),
                Poor = await _context.Assets.Where(a => a.Condition == AssetCondition.Poor).CountAsync()
            };  

            //Get the numbers for the different ticket status(Open, InProgress, Completed, Closed)
            var ticketsStatusMetrics = new TicketsStatusMetrics
            {
                Open = await _context.Tickets.Where(t => t.Status == TicketStatus.Open).CountAsync(),
                InProgress = await _context.Tickets.Where(t => t.Status == TicketStatus.InProgress).CountAsync(),
                Completed = await _context.Tickets.Where(t => t.Status == TicketStatus.Completed).CountAsync(),
                Closed = await _context.Tickets.Where(t => t.Status == TicketStatus.Closed).CountAsync()
            };      

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