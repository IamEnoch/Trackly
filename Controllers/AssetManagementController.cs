using Microsoft.AspNetCore.Mvc;

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetManagementController : ControllerBase
    {

        private readonly ILogger<AssetManagementController> _logger;

        public AssetManagementController(ILogger<AssetManagementController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAssets")]
        public void GetAssets()
        {
                                   
        }
    }
}
