using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trackly.API.Models;

namespace Trackly.API.Interfaces
{
    public interface IMetricsService
    {
        Task<Metrics> GetMetricsAsync();
    }
}