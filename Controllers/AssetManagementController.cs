using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs;
using TracklyApi.Models;

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
            var response = await _context.Assets.ToListAsync(); 
            return Ok(response);
        }

        /// <summary>
        /// Get asset by barcode number
        /// </summary>
        /// <param name="barcodeNumber"></param>
        /// <returns>An asset based on barcode number</returns>
        [HttpGet("assets/{barcodeNumber}")]
        public async Task<ActionResult<AssetDto>> GetAsset(string barcodeNumber)
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
                .Where(t => t.AssetId == asset.AssetID)
                .ToListAsync();

            return Ok(new AssetDto(asset.BarcodeNumber, asset.AssetName, asset.Category, asset.Department.DepartmentName, asset.Location.LocationName, tickets));
        }

        //public async Task<ActionResult<Asset>> CreateAsset(Asset asset)
        //{
        //    _context.Assets.Add(asset);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetAsset), new { id = asset.AssetID }, asset);
        //}
    }
}
