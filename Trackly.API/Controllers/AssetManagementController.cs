using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs;
using TracklyApi.DTOs.RequestDTOs;
using TracklyApi.Models.Assets;

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetManagementController : ControllerBase
    {

        private readonly ILogger<AssetManagementController> _logger;
        private readonly AppDbContext _context;

        public AssetManagementController(ILogger<AssetManagementController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Get assets
        /// </summary>
        /// <returns>List of assets</returns>
        [HttpGet("assets")]

        public async Task<ActionResult<IEnumerable<Asset>>> GetAssets()
        {
            // Fetching assets with their tickets separately
            var assets = await _context.Assets
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
                asset.AssetName,
                asset.Category,
                asset.Department.DepartmentName,
                asset.Location.LocationName,
                tickets.Where(t => t.AssetID == asset.AssetID).ToList()
            )).ToList();
            return Ok(response);
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
                .Where(t => t.AssetID == asset.AssetID)
                .ToListAsync();

            return Ok(new AssetResponseDto(asset.BarcodeNumber, asset.AssetName, asset.Category, asset.Department.DepartmentName, asset.Location.LocationName, tickets));
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
                .FirstOrDefaultAsync(a => a.AssetID == Guid.Parse(id));

            if (asset == null)
            {
                return NotFound();
            }

            var tickets = await _context.Tickets
                .Where(t => t.AssetID == asset.AssetID)
                .ToListAsync();

            return Ok(new AssetResponseDto(asset.BarcodeNumber, asset.AssetName, asset.Category, asset.Department.DepartmentName, asset.Location.LocationName, tickets));
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
                    DepartmentID = _context.Departments.FirstOrDefault(d => d.DepartmentName == Enum.Parse<Helpers.EnumHelper.DepartmentEnum>(assetRequestDto.DepartmentName)).DepartmentID,
                    LocationID = _context.Locations.FirstOrDefault(l => l.LocationName == Enum.Parse<Helpers.EnumHelper.LocationEnum>(assetRequestDto.LocationName)).LocationID
                };

                _context.Assets.Add(asset);
                await _context.SaveChangesAsync();

                var resultId = new { id = asset.AssetID };
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

        //    return CreatedAtAction(nameof(GetAsset), new { id = asset.AssetID }, asset);
        //}
    }
}
