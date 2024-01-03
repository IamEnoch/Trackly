using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs;
using TracklyApi.DTOs.PartialUpdate;
using TracklyApi.DTOs.RequestDTOs;
using TracklyApi.Helpers;
using TracklyApi.Models.Tickets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ILogger<AssetManagementController> _logger;
        private readonly AppDbContext _context;
        public TicketsController(ILogger<AssetManagementController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //create a work item independent of ticket model class
        //ticket created when the work item is approved
        [HttpPost("Workitem")]
        public async Task<ActionResult<WorkItem>> CreateWorkItem(WorkItemRequestDto workItemRequestDto)
        {
            try
            {
                //check if asset id exists first or assetId fails to parse or assetId is null            
                var asset = await _context.Assets.FindAsync(Guid.Parse(workItemRequestDto.AssetId));
                if (!Guid.TryParse(workItemRequestDto.AssetId, out Guid assetId))
                {
                    return BadRequest("Asset Id is not valid");
                }

                var workItem = new WorkItem
                {
                    Title = workItemRequestDto.Title,
                    Description = workItemRequestDto.Description,
                    Status = EnumHelper.WorkItemStatus.Pending,
                    Priority = Enum.Parse<EnumHelper.Priority>(workItemRequestDto.Priority),
                    Category = Enum.Parse<EnumHelper.TicketCategory>(workItemRequestDto.Category),
                    AssetId = assetId,
                    CreatedAt = DateTime.Now
                };

                _context.WorkItems.Add(workItem);
                await _context.SaveChangesAsync();

                return Ok(workItem);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        //put request to change the status of a ticket
        [HttpPut("{ticketId}/status")]
        public async Task<ActionResult<Ticket>> ChangeTicketStatus(string ticketId, TicketStatusUpdateDto ticketStatusUpdateDto)
        {
            try
            {
                var ticket = await _context.Tickets.FindAsync(Guid.Parse(ticketId));
                if (ticket == null)
                {
                    return NotFound("Ticket not found");
                }

                ticket.Status = Enum.Parse<TicketStatus>(ticketStatusUpdateDto.Status);
                await _context.SaveChangesAsync();

                return Ok(ticket);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
        
}
