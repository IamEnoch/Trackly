using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using TracklyApi.Data;
using TracklyApi.DTOs;
using TracklyApi.DTOs.Output;
using TracklyApi.DTOs.RequestDTOs;
using TracklyApi.Models;
using TracklyApi.Models.Assets;

namespace TracklyApi.Controllers
{
    [ApiController]
    public class AssetsController : ControllerBase
    {

        private readonly ILogger<AssetsController> _logger;
        private readonly AppDbContext _context;

        public AssetsController(ILogger<AssetsController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

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
                var assets = await _context.Assets
                    .Include(x => x.Department)
                    .Include(x => x.Location)
                    .ToListAsync();

<<<<<<< Updated upstream
                var assetIds = assets.Select(a => a.AssetID).ToList();
=======
            var assetIds = assets.Select(a => a.AssetId).ToList();
>>>>>>> Stashed changes

                // Fetching tickets for the fetched assets
                var tickets = await _context.Tickets
                    .Where(t => assetIds.Contains(t.AssetID))
                    .ToListAsync();

<<<<<<< Updated upstream
                // Constructing the response using the fetched data
                var response = assets.Select(asset => new AssetResponseDto(
                    asset.BarcodeNumber,
                    asset.AssetID,
                    asset.AssetName,
                    asset.Category,
                    asset.Department.DepartmentName,
                    asset.Location.LocationName,
                    tickets.Where(t => t.AssetID == asset.AssetID).ToList()
                )).ToList();


                return Ok(response);
            }
            catch (Exception e)
            {
                //status code 500
                return StatusCode(500, e.Message);
                throw;
            }
=======
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
                tickets.Where(t => t.AssetID == asset.AssetId).ToList()
            )).ToList();
            return Ok(response);
>>>>>>> Stashed changes
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
                var totaNummberOfAssets = await _context.Assets.CountAsync();
                var assets = await _context.Assets
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .Include(x => x.Department)
                    .Include(x => x.Location)
                    .ToListAsync();

                var assetIds = assets.Select(a => a.AssetID).ToList();

                // Fetching tickets for the fetched assets
                var tickets = await _context.Tickets
                    .Where(t => assetIds.Contains(t.AssetID))
                    .ToListAsync();

                // Constructing the response using the fetched data
                var response = assets.Select(asset => new AssetResponseDto(
                    asset.BarcodeNumber,
                    asset.AssetID,
                    asset.AssetName,
                    asset.Category,
                    asset.Department.DepartmentName,
                    asset.Location.LocationName,
                    tickets.Where(t => t.AssetID == asset.AssetID).ToList()
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
                throw;
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
            var asset = await _context.Assets
                .Include(a => a.Department)
                .Include(a => a.Location)
                .FirstOrDefaultAsync(a => a.BarcodeNumber == barcodeNumber);

            if (asset == null)
            {
                return NotFound();
            }

            var tickets = await _context.Tickets
                .Where(t => t.AssetID == asset.AssetId)
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
            var asset = await _context.Assets
                .Include(a => a.Department)
                .Include(a => a.Location)
                .FirstOrDefaultAsync(a => a.AssetId == Guid.Parse(id));

            if (asset == null)
            {
                return NotFound();
            }

            var tickets = await _context.Tickets
                .Where(t => t.AssetID == asset.AssetId)
                .ToListAsync();

            return Ok(new AssetResponseDto(asset.BarcodeNumber, asset.AssetId, asset.AssetName, 
                asset.Category, asset.Department.DepartmentName, asset.Location.LocationName
                ,asset.Description, asset.CreatedAt, asset.UpdatedAt, asset.DeletedAt, asset.PurchaseDate, asset.PurchaseCost,
                asset.Storage, asset.Processor, asset.SerialNumber, asset.Ram, asset.AssignedTo, asset.Condition,tickets));
        }

        /// <summary>
        /// Create asset
        /// </summary>
        /// <param name="assetRequestDto"></param>
        /// <returns>Return created asset details</returns>
        [HttpPost("assets/")]
        public async Task<ActionResult<AssetResponseDto>> CreateAsset([FromBody] AssetRequestDto assetRequestDto) 
        {
            //check if asset already exists
            var assetExists = await _context.Assets.AnyAsync(a => a.BarcodeNumber == assetRequestDto.BarcodeNumber);
            if (assetExists)
            {
                return BadRequest("Asset already exist");
            }

            //wrap in try catch
            try
            {
                var asset = new Asset
                {

                    AssetName = assetRequestDto.AssetName,
                    BarcodeNumber = assetRequestDto.BarcodeNumber,
                    Category = Enum.Parse<Helpers.EnumHelper.AssetCategory>(assetRequestDto.Category),
                    DepartmentId = _context.Departments.FirstOrDefault(d => d.DepartmentName == Enum.Parse<Helpers.EnumHelper.DepartmentEnum>(assetRequestDto.DepartmentName)).DepartmentId,
                    LocationId = _context.Locations.FirstOrDefault(l => l.LocationName == Enum.Parse<Helpers.EnumHelper.LocationEnum>(assetRequestDto.LocationName)).LocationID
                };

                _context.Assets.Add(asset);
                await _context.SaveChangesAsync();

                var resultId = new { id = asset.AssetId };
                return await GetAssetById(resultId.id.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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
