using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs.RequestDTOs;
using TracklyApi.Helpers;
using TracklyApi.Models.Tickets;

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ILogger<AssetManagementController> _logger;
        private readonly AppDbContext _context;
        public TicketController(ILogger<AssetManagementController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //create a work item independent of ticket model class
        //ticket created when the work item is approved
        [HttpPost("create")]
        public async Task<ActionResult<WorkItem>> CreateWorkItem(WorkItemRequestDto workItemRequestDto)
        {
            var workItem = new WorkItem
            {
                Title = workItemRequestDto.Title,
                Description = workItemRequestDto.Description,
                Status = Enum.Parse<EnumHelper.WorkItemStatus>(workItemRequestDto.Status),
                Priority = Enum.Parse<EnumHelper.Priority>(workItemRequestDto.Priority),
                Category = Enum.Parse<EnumHelper.TicketCategory>(workItemRequestDto.Category),
                AssetId = Guid.Parse(workItemRequestDto.AssetId),
                CreatedAt = DateTime.Now
            };

            _context.WorkItems.Add(workItem);
            await _context.SaveChangesAsync();

            return Ok(workItem);
        }

    }
}
