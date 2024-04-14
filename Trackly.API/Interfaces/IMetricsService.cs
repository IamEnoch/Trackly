using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trackly.API.Models;
using Trackly.API.Models.Metrics;

namespace Trackly.API.Interfaces
{
    public interface IMetricsService
    {
        Task<Metrics> GetMetricsAsync();

        //Task<PdfMetrics> GetReportMetricsAsync();
    }
}