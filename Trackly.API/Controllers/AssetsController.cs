using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing.Printing;
using TracklyApi.Data;
using TracklyApi.DTOs;
using TracklyApi.DTOs.Input;
using TracklyApi.DTOs.Output;
using TracklyApi.DTOs.RequestDTOs;
using TracklyApi.Models;
using TracklyApi.Models.Assets;
using TracklyApi.Models.Tickets;

namespace TracklyApi.Controllers
{
    [ApiController]
    public class AssetsController(ILogger<AssetsController> _logger, AppDbContext context) : ControllerBase
    {
        /// <summary>
        /// Get assets
        /// </summary>
        /// <returns>List of assets</returns>
        [HttpGet("assets")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Asset>>> GetAssets()
        {
            try
            {
                // Fetching assets with their tickets separately
                var assets = await context.Assets
                    .Include(x => x.Department)
                    .Include(x => x.Location)
                    .ToListAsync();

            var assetIds = assets.Select(a => a.AssetId).ToList();
                // Fetching tickets for the fetched assets
                var tickets = await context.Tickets
                    .Where(t => assetIds.Contains(t.AssetId))
                    .ToListAsync();

                // Constructing the response using the fetched data
                // Constructing the response using the fetched data
                var response = assets.Select(asset => new AssetResponseDto(
                    asset.BarcodeNumber,
                    asset.AssetId,
                    asset.AssetName,
                    asset.Category,
                    asset.Department.DepartmentName,
                    asset.Location.LocationName,
                    asset.Description,
                    asset.CreatedAt,
                    asset.UpdatedAt,
                    asset.DeletedAt,
                    asset.PurchaseDate,
                    asset.PurchaseCost,
                    asset.Storage,
                    asset.Processor,
                    asset.SerialNumber,
                    asset.Ram,
                    asset.AssignedTo,
                    asset.Condition,
                    tickets.Where(t => t.AssetId == asset.AssetId).ToList()
                )).ToList();
                return Ok(response);
            }
            catch (Exception e)
            {
                //status code 500
                return StatusCode(500, e.Message);
                throw;
            }
            
        }

        //get paged assets
        [HttpGet("assets/paged")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Asset>>> GetPagedAssets([FromQuery] QueryParameters parameters)
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

                // Fetching assets with their tickets separately
                var totaNummberOfAssets = await context.Assets.CountAsync();
                var assets = await context.Assets
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .Include(x => x.Department)
                    .Include(x => x.Location)
                    .ToListAsync();

                var assetIds = assets.Select(a => a.AssetId).ToList();

                // Fetching tickets for the fetched assets
                var tickets = await context.Tickets
                    .Where(t => assetIds.Contains(t.AssetId))
                    .ToListAsync();

                // Constructing the response using the fetched data
                var response = assets.Select(asset => new AssetResponseDto(
                    asset.BarcodeNumber,
                    asset.AssetId,
                    asset.AssetName,
                    asset.Category,
                    asset.Department.DepartmentName,
                    asset.Location.LocationName,
                    asset.Description,
                    asset.CreatedAt,
                    asset.UpdatedAt,
                    asset.DeletedAt,
                    asset.PurchaseDate,
                    asset.PurchaseCost,
                    asset.Storage,
                    asset.Processor,
                    asset.SerialNumber,
                    asset.Ram,
                    asset.AssignedTo,
                    asset.Condition,
                    tickets.Where(t => t.AssetId == asset.AssetId).ToList()
                )).ToList();


                return Ok(new PagedResult<AssetResponseDto> 
                {
                    Items = response,
                    TotalCount = totaNummberOfAssets,
                    PageNumber = parameters.PageNumber,
                    RecordNumber = parameters.PageSize
                });
            }
            catch (Exception e)
            {
                //status code 500
                return StatusCode(500, e.Message);
            }
        }


        /// <summary>
        /// Get asset by barcode number
        /// </summary>
        /// <param name="barcodeNumber"></param>
        /// <returns>An asset based on barcode number</returns>
        [HttpGet("assets/{barcodeNumber}")]
        public async Task<ActionResult<AssetResponseDto>> GetAssetByBarcodeNumber(string barcodeNumber)
        {
            //use asset dto
            var asset = await context.Assets
                .Include(a => a.Department)
                .Include(a => a.Location)
                .FirstOrDefaultAsync(a => a.BarcodeNumber == barcodeNumber);

            if (asset == null)
            {
                return NotFound();
            }

            var tickets = await context.Tickets
                .Where(t => t.AssetId == asset.AssetId)
                .ToListAsync();

            return Ok(new AssetResponseDto(asset.BarcodeNumber, asset.AssetId, asset.AssetName, asset.Category, 
                asset.Department.DepartmentName, asset.Location.LocationName,
                asset.Description, asset.CreatedAt, asset.UpdatedAt, asset.DeletedAt, asset.PurchaseDate, asset.PurchaseCost,
                asset.Storage, asset.Processor, asset.SerialNumber, asset.Ram, asset.AssignedTo, asset.Condition,tickets));
        }

        /// <summary>
        /// Get asset by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Asset </returns>
        [HttpGet("assets/id/{id}")]
        public async Task<ActionResult<AssetResponseDto>> GetAssetById(string id)
        {
            //use asset dto
            var asset = await context.Assets
                .Include(a => a.Department)
                .Include(a => a.Location)
                .FirstOrDefaultAsync(a => a.AssetId == Guid.Parse(id));

            if (asset == null)
            {
                return NotFound();
            }

            var tickets = await context.Tickets
                .Where(t => t.AssetId == asset.AssetId)
                .ToListAsync();

            return Ok(new AssetResponseDto(asset.BarcodeNumber, asset.AssetId, asset.AssetName, 
                asset.Category, asset.Department.DepartmentName, asset.Location.LocationName
                ,asset.Description, asset.CreatedAt, asset.UpdatedAt, asset.DeletedAt, asset.PurchaseDate, asset.PurchaseCost,
                asset.Storage, asset.Processor, asset.SerialNumber, asset.Ram, asset.AssignedTo, asset.Condition,tickets));
        }

        /// <summary>
        /// Create asset
        /// </summary>
        /// <param name="assetRequestCreateDto"></param>
        /// <returns>Return created asset details</returns>
        [HttpPost("assets/")]
        public async Task<ActionResult<AssetResponseDto>> CreateAsset([FromBody] AssetRequestCreateDto assetRequestCreateDto) 
        {
            //check if asset already exists
            var assetExists = await context.Assets.AnyAsync(a => a.BarcodeNumber == assetRequestCreateDto.BarcodeNumber);
            if (assetExists)
            {
                return BadRequest("Asset already exist");
            }

            //wrap in try catch
            try
            {
                var asset = new Asset
                {

                    AssetName = assetRequestCreateDto.AssetName,
                    BarcodeNumber = assetRequestCreateDto.BarcodeNumber,
                    Category = Enum.Parse<Helpers.EnumHelper.AssetCategory>(assetRequestCreateDto.Category),
                    DepartmentId = context.Departments.FirstOrDefault(d => d.DepartmentName == Enum.Parse<Helpers.EnumHelper.DepartmentEnum>(assetRequestCreateDto.DepartmentName)).DepartmentId,
                    LocationID = context.Locations.FirstOrDefault(l => l.LocationName == Enum.Parse<Helpers.EnumHelper.LocationEnum>(assetRequestCreateDto.LocationName)).LocationID,
                    AssignedTo = assetRequestCreateDto.AssignedTo,
                    Condition = Enum.Parse<Helpers.EnumHelper.AssetCondition>(assetRequestCreateDto.Condition),
                    Ram = assetRequestCreateDto.Ram,
                    SerialNumber = assetRequestCreateDto.SerialNumber,
                    Processor = assetRequestCreateDto.Processor,
                    Storage = assetRequestCreateDto.Storage,
                    Description = assetRequestCreateDto.Description,
                    PurchaseCost = assetRequestCreateDto.PurchaseCost,
                    PurchaseDate = assetRequestCreateDto.PurchaseDate,
                    CreatedAt = DateTime.Now,
                    
                };

                context.Assets.Add(asset);
                await context.SaveChangesAsync();

                var resultId = new { id = asset.AssetId };
                return await GetAssetById(resultId.id.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }   
        }

        //Update an existing asset
        [HttpPut("assets/{id}")]
        public async Task<ActionResult<AssetResponseDto>> UpdateAsset(string id,
            [FromBody] AssetRequestUpdateDto assetRequestUpdateDto)
        {
            try
            {
                var asset = await context.Assets.FindAsync(Guid.Parse(id));
                if (asset == null)
                {
                    return NotFound();
                }

                //If assigned null and the value from db should not be null, retain the initial value
                asset.AssetName = assetRequestUpdateDto.AssetName ?? asset.AssetName;
                asset.BarcodeNumber = assetRequestUpdateDto.BarcodeNumber ?? asset.BarcodeNumber;
                asset.Category = assetRequestUpdateDto.Category == null ? asset.Category : Enum.Parse<Helpers.EnumHelper.AssetCategory>(assetRequestUpdateDto.Category);
                asset.DepartmentId = assetRequestUpdateDto.Department == null ? asset.DepartmentId : context.Departments.FirstOrDefault(d =>
                        d.DepartmentName ==
                        Enum.Parse<Helpers.EnumHelper.DepartmentEnum>(assetRequestUpdateDto.Department))!
                    .DepartmentId;
                asset.LocationID = assetRequestUpdateDto.Location == null ? asset.LocationID : context.Locations.FirstOrDefault(l =>
                        l.LocationName == Enum.Parse<Helpers.EnumHelper.LocationEnum>(assetRequestUpdateDto.Location))!
                    .LocationID;
                asset.Condition = assetRequestUpdateDto.Condition == null ? asset.Condition :Enum.Parse<Helpers.EnumHelper.AssetCondition>(assetRequestUpdateDto.Condition);
                asset.Ram = assetRequestUpdateDto.Ram ?? asset.Ram;
                asset.SerialNumber = assetRequestUpdateDto.SerialNumber ?? asset.SerialNumber;
                asset.AssignedTo = assetRequestUpdateDto.AssignedToId ?? asset.AssignedTo;
                asset.Processor = assetRequestUpdateDto.Processor ?? asset.Processor;
                asset.Storage = assetRequestUpdateDto.Storage ?? asset.Storage;
                asset.Description = assetRequestUpdateDto.Description ?? asset.Description;
                asset.PurchaseCost = assetRequestUpdateDto.PurchaseCost == null ? asset.PurchaseCost : Convert.ToDecimal(assetRequestUpdateDto.PurchaseCost);
                asset.UpdatedAt = DateTime.Now;
                asset.DeletedAt = assetRequestUpdateDto.DeletedAt ?? asset.DeletedAt;


                await context.SaveChangesAsync();

                return Ok(asset);

            }
            
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }   
        }



        //public async Task<ActionResult<Asset>> CreateAsset(Asset asset)
        //{
        //    _context.Assets.Add(asset);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetAsset), new { id = asset.AssetId }, asset);
        //}
    }
}
