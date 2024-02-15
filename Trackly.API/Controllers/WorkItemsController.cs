﻿using Azure;
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

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("workitems")]
    public class WorkItemsController(ILogger<AssetsController> logger, AppDbContext context) : ControllerBase
    {
        private readonly ILogger<AssetsController> _logger = logger;

        //create a work item independent of ticket model class
        //ticket created when the work item is approved
        [HttpPost("")]
        public async Task<ActionResult<string>> CreateWorkItem(WorkItemRequestDto workItemRequestDto)
        {
            try
            {
                //check if asset id exists first or assetId fails to parse or assetId is null            
                var asset = await context.Assets.FindAsync(Guid.Parse(workItemRequestDto.AssetId));
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
                    CreatedAt = DateTime.Now
                };

                context.WorkItems.Add(workItem);
                await context.SaveChangesAsync();

                return Ok("workItem created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        //Change the status of the work-item
        [HttpPut("{id}/status")]
        public async Task<ActionResult<WorkItem>> UpdateWorkItemStatus(Guid id, WorkItemUpdateDto workItemUpdateDto)
        {
            try
            {
                var workItem = await context.WorkItems.FindAsync(id);
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
                        CreatedAt = DateTime.Now
                    };

                    context.Tickets.Add(ticket);
                }
                await context.SaveChangesAsync();

                return Ok(workItem);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        //Get all the work-items that are pending
        [HttpGet("pending")]
        public async Task<ActionResult<IEnumerable<WorkItem>>> GetPendingWorkItems()
        {
            try
            {
                var workItems =  context.WorkItems
                    .Where(w => w.Status == EnumHelper.WorkItemStatus.Pending)
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
        public async Task<ActionResult<IEnumerable<WorkItem>>> GetPagedPendingWorkItems(
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


                var totalNumberOfWorkItems = await context.WorkItems.CountAsync();
                var workItems = await context.WorkItems
                    .Where(w => w.Status == EnumHelper.WorkItemStatus.Pending)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                return Ok(new PagedResult<WorkItem>
                {
                    Items = workItems,
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
