using Microsoft.EntityFrameworkCore;
using TracklyApi.Models;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>()
                .HasIndex(a => a.BarcodeNumber)
                .IsUnique();

            // Other configurations...


            base.OnModelCreating(modelBuilder);

            // Seed Departments (3 entries)
            var departmentGuids = new List<Guid>();
            for (int i = 0; i < 3; i++)
            {
                var departmentId = Guid.NewGuid();
                departmentGuids.Add(departmentId);
                modelBuilder.Entity<Department>().HasData(
                    new Department { DepartmentID = departmentId, DepartmentName = (DepartmentEnum)i }
                );
            }

            // Seed Locations (3 entries)
            var locationGuids = new List<Guid>();
            for (int i = 0; i < 3; i++)
            {
                var locationId = Guid.NewGuid();
                locationGuids.Add(locationId);
                modelBuilder.Entity<Location>().HasData(
                    new Location { LocationID = locationId, LocationName = (LocationEnum)i }
                );
            }

            // Seed Assets (70 entries)
            var assetGuids = new List<Guid>();
            var assets = new List<Asset>();
            var barcodeStartNumber = 100000000000;
            for (int i = 0; i < 70; i++)
            {
                var assetId = Guid.NewGuid();
                assetGuids.Add(assetId);
                // Generate UPC-A barcode numbers
                var barcodeNumber = (barcodeStartNumber + i).ToString();
                assets.Add(new Asset
                {
                    AssetID = assetId,
                    BarcodeNumber = barcodeNumber,
                    AssetName = $"Asset {i + 1}",
                    Category = (AssetCategory)(i % Enum.GetValues(typeof(AssetCategory)).Length),
                    DepartmentID = departmentGuids[i % 3],
                    LocationID = locationGuids[i % 3]
                });
            }
            modelBuilder.Entity<Asset>().HasData(assets);

            // Seed Tickets (50 entries)
            var tickets = new List<Ticket>();
            for (int i = 0; i < 50; i++)
            {
                tickets.Add(new Ticket
                {
                    TicketId = Guid.NewGuid(),
                    Title = $"Ticket {i + 1}",
                    Description = $"Description for Ticket {i + 1}",
                    Status = (TicketStatus)(i % Enum.GetValues(typeof(TicketStatus)).Length),
                    Priority = (Priority)(i % Enum.GetValues(typeof(Priority)).Length),
                    Category = (TicketCategory)(i % Enum.GetValues(typeof(TicketCategory)).Length),
                    AssignedUserID = null, // Set AssignedUserID as null for now
                    AssetId = assetGuids[i % 30] // Use Asset ID
                });
            }
            modelBuilder.Entity<Ticket>().HasData(tickets);
        }
    }
    
}
