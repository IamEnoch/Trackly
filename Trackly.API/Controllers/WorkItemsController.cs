using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs.Output;
using TracklyApi.DTOs.PartialUpdate;
using TracklyApi.DTOs.RequestDTOs;
using TracklyApi.Helpers;
using TracklyApi.Models;
using TracklyApi.Models.Tickets;

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("workitems")]
    public class WorkItemsController(ILogger<AssetsController> logger, AppDbContext _context) : ControllerBase
    {
        private readonly ILogger<AssetsController> _logger = logger;

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

        //create a work item independent of ticket model class
        //ticket created when the work item is approved
        [HttpPost("")]
        public async Task<ActionResult<string>> CreateWorkItem(WorkItemRequestDto workItemRequestDto)
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
                    CreatorUserID = workItemRequestDto.CreatorUserId,
                    AssetId = assetId,
                    CreatedAt = DateTime.UtcNow
                };

                _context.WorkItems.Add(workItem);
                await _context.SaveChangesAsync();

                return Ok("workItem created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        //Change the status of the work-item
        [HttpPut("{id}/status")]
        public async Task<ActionResult<WorkItem>> UpdateWorkItemStatus(string id, [FromBody]WorkItemUpdateDto workItemUpdateDto)
        {

            //convert string to guid
            if (!Guid.TryParse(id, out Guid workItemId))
            {
                return BadRequest("Invalid work item id");
            }
            try
            {
                var workItem = await _context.WorkItems.Where(e => e.WorkItemId == workItemId).FirstOrDefaultAsync();
                if (workItem == null)
                {
                    return NotFound();
                }

                workItem.Status = Enum.Parse<EnumHelper.WorkItemStatus>(workItemUpdateDto.WorkItemStatus);

                //if work item is approved, create a ticket
                if (workItem.Status == EnumHelper.WorkItemStatus.Approved)
                {


                    var ticket = new Ticket
                    {
                        Title = workItem.Title,
                        Description = workItem.Description,
                        Status = EnumHelper.TicketStatus.Open,
                        Priority = workItem.Priority,
                        Category = workItem.Category,
                        AssetID = workItem.AssetId,
                        CreatedAt = DateTime.Now,
                        CreatedBy = workItem.CreatorUserID,
                        AssignedUserID = workItem.CreatorUserID
                    };

                    _context.Tickets.Add(ticket);

                }
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        //Get all the work-items that are pending
        [HttpGet("pending")]
        public async Task<ActionResult<IEnumerable<WorkItem>>> GetPendingWorkItems()
        {
            try
            {
                var workItems = _context.WorkItems
                    .Where(w => w.Status == EnumHelper.WorkItemStatus.Pending)
                    .OrderByDescending(e => e.CreatedAt)
                    .AsEnumerable();

                return Ok(workItems);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Get paged work items that are pending
        [HttpGet("pending/paged")]
        public async Task<ActionResult<IEnumerable<WorkItemResponseDto>>> GetPagedPendingWorkItems(
            [FromQuery] QueryParameters parameters)
        {
            try
            {
                int page = parameters.PageNumber;
                int pageSize = parameters.PageSize;

                // Validate and normalize page and pageSize values
                if (parameters.PageNumber < 1) page = 1;
                if (parameters.PageSize < 1)
                {
                    pageSize = 15;
                };


                var totalNumberOfWorkItems = await _context.WorkItems.CountAsync();
                var workItems = await _context.WorkItems
                    .Where(w => w.Status == EnumHelper.WorkItemStatus.Pending)
                    .OrderByDescending(e => e.CreatedAt)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var workItemsDto = workItems.Select(w => new WorkItemResponseDto(w.WorkItemId.ToString(), w.Title, w.Description, w.Status.ToString(), w.Priority, w.Category, w.CreatorUserID, w.AssetId, w.CreatedAt)).ToList();

                return Ok(new PagedResult<WorkItemResponseDto>
                {
                    Items = workItemsDto,
                    TotalCount = totalNumberOfWorkItems,
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
