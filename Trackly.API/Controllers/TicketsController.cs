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
    [Route("tickets")]
    public class TicketsController : ControllerBase
    {
        private readonly ILogger<AssetsController> _logger;
        private readonly AppDbContext _context;
        public TicketsController(ILogger<AssetsController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        //get work item by id
        [HttpGet("workitem/{workItemId}")]
        public async Task<ActionResult<WorkItem>> GetWorkItemById(string workItemId)
        {
            try
            {
                var workItem = await _context.WorkItems.FindAsync(Guid.Parse(workItemId));
                if (workItem == null)
                {
                    return NotFound("Work item not found");
                }

                return Ok(workItem);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("workitem")]
        public async Task<ActionResult<WorkItem>> CreateWorkItem([FromBody]WorkItemRequestDto workItemRequestDto)
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


                var resultId = new { id = workItem.WorkItemId};
                return await GetWorkItemById(resultId.id.ToString());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        //put request to change the status of a ticket
        [HttpPut("{ticketId}/status")]
        public async Task<ActionResult<Ticket>> ChangeTicketStatus(string ticketId, [FromBody]TicketStatusUpdateDto ticketStatusUpdateDto)
        {
            try
            {
                var ticket = await _context.Tickets.FindAsync(Guid.Parse(ticketId));

                if (ticket == null)
                    return NotFound("Ticket not found");

                //set the current status of the ticket
                var previousTicketStatus = ticket.Status;
                ticket.Status = Enum.Parse<TicketStatus>(ticketStatusUpdateDto.Status);

                //If previous status is completed, set to a different on => null
                //If previous status is closed, set to a different on => null
                if (previousTicketStatus == TicketStatus.Completed && ticket.Status != TicketStatus.Completed && ticket.Status != TicketStatus.Closed)
                {
                    ticket.CompletedAt = null;
                }else if (previousTicketStatus == TicketStatus.Closed && ticket.Status != TicketStatus.Closed)
                {
                    ticket.ClosedAt = null; 
                }

                switch (ticket.Status)
                {
                    case TicketStatus.Closed:
                        ticket.ClosedAt = DateTime.Now;
                        break;
                    case TicketStatus.Completed:
                        ticket.CompletedAt = DateTime.Now;
                        break;
                }
                
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
