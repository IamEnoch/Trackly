using Auth0.ManagementApi;
using Auth0.ManagementApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TracklyApi.Data;
using TracklyApi.DTOs;
using TracklyApi.Helpers;
using TracklyApi.Models.Auth;

namespace TracklyApi.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<AssetsController> _logger;
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        private readonly string _domain;
        private readonly string _clientId;
        private readonly string _clientSecret;

        public UsersController(ILogger<AssetsController> logger, AppDbContext context, IConfiguration configuration)
        {
            _logger = logger;
            _context = context;
            _configuration = configuration;

            _domain  = configuration["Auth0:Domain"];
            _clientId = configuration["Auth0:AuthClientId"];
            _clientSecret = configuration["Auth0:AuthClientSecret"];


        }

        /// <summary>
        /// GET request to get all users
        /// </summary>
        /// <returns>List of users</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUsers()
        {
            try
            {
                //Use http helper to get access token
                var httpHelper = new HttpHelper();
                //create a http uri
                var getTokeUri = new Uri($"https://{_domain}/oauth/token");
                var getUserUri = new Uri($"https://{_domain}/api/v2");
                //create a request object
                var request = new AuthManagementTokenRequest
                {
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Audience = new Uri($"https://{_domain}/api/v2/"),
                    GrantType = "client_credentials"
                };
                var result = await httpHelper.PostAsync<AuthManagementTokenRequest, AuthManagementTokenResponse>(getTokeUri.ToString(), request, new Dictionary<string, string>());
                var accessToken = result.AccessToken;
                var managementApiClient = new ManagementApiClient(accessToken, getUserUri);
                var users = await managementApiClient.Users.GetAllAsync(new GetUsersRequest()
                {
                    Connection = "",
                    Fields = "",
                    Query = "",
                    SearchEngine = "v3",
                    Sort = "created_at:1"
                });

                var newUsers = users.Select(user => new UserDto(user.Email, user.UserName, user.UserId, user.CreatedAt, user.UpdatedAt)).ToList();

                return newUsers;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        /// <summary>
        /// GET request to get a user by id
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDto>> GetUserById(string userId)
        {
            var userIdString = userId!;
            try
            {
                //Use http helper to get access token
                var httpHelper = new HttpHelper();
                //create a http uri
                var getTokeUri = new Uri($"https://{_domain}/oauth/token");
                var getUserUri = new Uri($"https://{_domain}/api/v2");
                //create a request object
                var request = new AuthManagementTokenRequest
                {
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Audience = new Uri($"https://{_domain}/api/v2/"),
                    GrantType = "client_credentials"
                };
                var result = await httpHelper.PostAsync<AuthManagementTokenRequest, UserAuthManagementTokenResponse>(getTokeUri.ToString(), request, new Dictionary<string, string>());
                var accessToken = result.AccessToken;

                //make a get request instead
                var user = await httpHelper.GetAsync<AuthUser?>($"{getUserUri}/users/{userIdString}", new Dictionary<string, string>
                {
                    { "Authorization", $"Bearer {accessToken}" }
                });
                //var user = await managementApiClient.Users.GetAsync(userId);
                if (user == null)
                {
                    return NotFound();
                }

                return new UserDto(user.Email, user.Nickname, user.UserId, user.CreatedAt, user.UpdatedAt);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        /// <summary>
        /// GET request to get a user`s role
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns>List of user`s role</returns>
        [HttpGet("{userId}/role")]
        public async Task<ActionResult<IEnumerable<UserRole?>>> GetUserRole(string userId)
        {
            try
            {
                //Use http helper to get access token
                var httpHelper = new HttpHelper();
                //create a http uri
                var getTokeUri = new Uri($"https://{_domain}/oauth/token");
                var getUserUri = new Uri($"https://{_domain}/api/v2");
                //create a request object
                var request = new AuthManagementTokenRequest
                {
                    ClientId = _clientId,
                    ClientSecret = _clientSecret,
                    Audience = new Uri($"https://{_domain}/api/v2/"),
                    GrantType = "client_credentials"
                };
                var result =
                    await httpHelper.PostAsync<AuthManagementTokenRequest, UserAuthManagementTokenResponse>(
                        getTokeUri.ToString(), request, new Dictionary<string, string>());
                var accessToken = result.AccessToken;

                //make a get request instead
                var userRoles = await httpHelper.GetAsync<IEnumerable<UserRole>?>($"{getUserUri}/users/{userId}/roles",
                    new Dictionary<string, string>
                    {
                        { "Authorization", $"Bearer {accessToken}" }
                    });
                //var user = await managementApiClient.Users.GetAsync(userId);
                if (userRoles == null)
                {
                    return NotFound();
                }


                return Ok(userRoles);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }


        /// <summary>
        /// GET request to get tickets of a particular user
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns></returns>
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
