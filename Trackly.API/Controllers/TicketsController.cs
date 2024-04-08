using Auth0.ManagementApi.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs;
using TracklyApi.DTOs.Output;
using TracklyApi.DTOs.PartialUpdate;
using TracklyApi.DTOs.RequestDTOs;
using TracklyApi.Helpers;
using TracklyApi.Models;
using TracklyApi.Models.Tickets;
using static TracklyApi.Helpers.EnumHelper;
using Ticket = TracklyApi.Models.Tickets.Ticket;

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
        

        //put request to change the status of a ticket
        [HttpPut("{ticketId}/status")]
        public async Task<ActionResult<Ticket>> ChangeTicketStatus(string ticketId, [FromBody]TicketStatusUpdateDto ticketStatusUpdateDto)
        {
            var ticket = await _context.Tickets.Where(e => e.TicketId == Guid.Parse(ticketId))
                .Include(ticket => ticket.Asset).FirstOrDefaultAsync();
            try
            {
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

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Get paginated tickets(TicketDto) that have been completed 
        [HttpGet("completed")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetPagedCompletedTickets(
            [FromQuery] QueryParameters parameters)
        {
            try
            {
                var totalNumberOfCompletedTickets = await _context.Tickets.Where(e => e.Status == TicketStatus.Completed).CountAsync();
                var tickets = await _context.Tickets.Where(e => e.Status == TicketStatus.Completed)
                    .Include(ticket => ticket.Asset)
                    .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                    .Take(parameters.PageSize)
                    .Select(ticket => new TicketDto(ticket.TicketId,ticket.Title, ticket.Description, ticket.Status, ticket.Priority,
                        ticket.Category, ticket.AssignedUserID, ticket.CreatedAt, ticket.CompletedAt, ticket.ClosedAt))
                    .ToListAsync();

                return Ok(new PagedResult<TicketDto>
                {
                    Items = tickets,
                    TotalCount = totalNumberOfCompletedTickets,
                    PageNumber = parameters.PageNumber,
                    RecordNumber = parameters.PageSize
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
            
        }

        //Get the all the tickets of a particular person(given their id) apart from closed ones
        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTechnicianTicketsByUserId(string userId, [FromQuery] QueryParameters parameters)
        {
            try
            {
                var totalNumberOfTickets = await _context.Tickets.Where(e => e.AssignedUserID == userId && e.Status != TicketStatus.Closed).CountAsync();
                //Order by date. The most recent ticket should be at the top
                var tickets = await _context.Tickets.Where(e => e.AssignedUserID == userId && e.Status != TicketStatus.Closed)
                    .Include(ticket => ticket.Asset)
                    .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                    .Take(parameters.PageSize)
                    .OrderByDescending(ticket => ticket.CreatedAt)
                    .Select(ticket => new TicketDto(ticket.TicketId, ticket.Title, ticket.Description, ticket.Status,
                                               ticket.Priority,
                                               ticket.Category, ticket.AssignedUserID, ticket.CreatedAt, ticket.CompletedAt, ticket.ClosedAt))
                    .ToListAsync();


                return Ok(new PagedResult<TicketDto>
                {
                    Items = tickets,
                    TotalCount = totalNumberOfTickets,
                    PageNumber = parameters.PageNumber,
                    RecordNumber = parameters.PageSize
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
        
}
