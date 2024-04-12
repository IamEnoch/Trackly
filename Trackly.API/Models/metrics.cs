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
        public AssetsCategoryMetrics AssetsCategoryMetrics { get; set; }
    }

    public class AssetsCategoryMetrics{
        public int Desktop { get; set; }
        public int Laptop { get; set; }
        public int Monitor { get; set; }
        public int Other { get; set; }
        public int Printer { get; set; }
        public int Projector { get; set; }
        public int Scanner { get; set; }
    }
}