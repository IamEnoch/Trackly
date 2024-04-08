using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Trackly.API.Interfaces;
using Trackly.API.Services;

namespace Trackly.API.Controllers
{
    [ApiController]
    public class MetricsController : ControllerBase
    {
        private readonly IMetricsService _metricsService;

        public MetricsController(IMetricsService metricsService)
        {
            _metricsService = metricsService;
        }
        
        //Get the metrics for the dashboard using metrics service
        [HttpGet("/metrics")]
        public async Task<IActionResult> GetMetrics()
        {
            var metrics = await _metricsService.GetMetricsAsync();
            return Ok(metrics);
        }       
        
    }
}