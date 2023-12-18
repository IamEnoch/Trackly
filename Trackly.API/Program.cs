using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using TracklyApi.Data;
using TracklyApi.Models.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("TracklyDbConnectionString");
var domain = builder.Configuration["Auth0:Domain"];
var apiIdentifier = builder.Configuration["Auth0:ApiIdentifier"];

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configure DbContext with sql
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//Add authentication services
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Authority = $"https://{domain}/";
    options.Audience = apiIdentifier;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        NameClaimType = ClaimTypes.NameIdentifier
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("read:assets", policy => policy.Requirements.Add(new
    HasScopeRequirement("read:assets", domain)));

    options.AddPolicy("create:assets", policy => policy.Requirements.Add(new
    HasScopeRequirement("create:assets", domain)));

    options.AddPolicy("update:assets", policy => policy.Requirements.Add(new
    HasScopeRequirement("update:assets", domain)));

    options.AddPolicy("delete:assets", policy => policy.Requirements.Add(new
    HasScopeRequirement("delete:assets", domain)));
});

builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

// 2. Enable authentication middleware
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
