using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs;

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<AssetsController> _logger;
        private readonly AppDbContext _context;
        public UsersController(ILogger<AssetsController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        //get tickets of a particular user
        [HttpGet("{userId}/tickets")]
        public async Task<ActionResult<IEnumerable<TicketDto>>> GetTicketsByUserId(string userId)
        {
            try
            {
                var tickets = await _context.Tickets
                    .Where(t => t.AssignedUserID == Guid.Parse(userId))
                    .ToListAsync();

                // Constructing the response using the fetched data
                var response = tickets.Select(ticket => new TicketDto(
                    ticket.Title, ticket.Description, ticket.Status, ticket.Priority, ticket.Category, ticket.AssignedUserID, ticket.CreatedAt, ticket.CompletedAt, ticket.ClosedAt)
                { Id = ticket.TicketId.ToString()})
                    .ToList();
                
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

    }
}
