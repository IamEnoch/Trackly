using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trackly.API.Models.Metrics
{
    public class Metrics
    {
        public int TotalAssets { get; set; }
        public int AssetsUnderMaintenance { get; set; }
        public int AssetsNotUnderMaintenance { get; set; }
        public int TotalTickets { get; set; }
        public AssetsConditionMetrics AssetsConditionMetrics { get; set; }
        public TicketsStatusMetrics TicketsStatusMetrics { get; set; }
    }   

    
}