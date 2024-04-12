using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trackly.API.Models
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

    public class AssetsConditionMetrics{
        public int New { get; set; }
        public int Good { get; set; }
        public int Fair { get; set; }
        public int Broken { get; set; }
        public int Poor { get; set; }
    }

    public class TicketsStatusMetrics{
        public int Open { get; set; }
        public int InProgress { get; set; }
        public int Completed { get; set; }
        public int Closed { get; set; }
    }
}