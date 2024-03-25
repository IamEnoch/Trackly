using Microsoft.EntityFrameworkCore;
using TracklyApi.Models.Assets;
using TracklyApi.Models.Tickets;
using static TracklyApi.Helpers.EnumHelper;

namespace TracklyApi.Data
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }

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
                    new Department { DepartmentId = departmentId, DepartmentName = (DepartmentEnum)i }
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
            var usersIds = new List<String>()
            {
                "auth0|65b7dee72e02f54da98cd265",
                "auth0|65a4f8d7364ff592a0792a42",
                "auth0|65b7de875bf9ce48b47eedaa",
                "auth0|65a4fd318d9d565392c4972a"
            };
            for (int i = 0; i < 70; i++)
            {
                var assetId = Guid.NewGuid();
                assetGuids.Add(assetId);
                // Generate UPC-A barcode numbers
                var barcodeNumber = (barcodeStartNumber + i).ToString();
                assets.Add(new Asset
                {
                    AssetId = assetId,
                    BarcodeNumber = barcodeNumber,
                    AssetName = $"Asset {i + 1}",
                    Category = (AssetCategory)(i % Enum.GetValues(typeof(AssetCategory)).Length),
                    DepartmentId = departmentGuids[i % 3],
                    LocationId = locationGuids[i % 3],
                    //Randomly assign assigned to from the list of users id
                    AssignedTo = usersIds[i % 4],
                    Condition = (AssetCondition)(i % Enum.GetValues(typeof(AssetCondition)).Length),
                    Ram = $"{i + 1} GB",
                    Processor = $"Intel Core i{i + 3}",
                    Storage = $"{i + 1} TB",
                    Description = $"Description for Asset {i + 1}",
                    //Randomly assign purchase cost from 100 to 1000
                    PurchaseCost = (decimal)(i + 1) * 100,
                    //Generate serial number with a mix of letters and numbers with such format: LLLLDDDDD
                    SerialNumber = $"{(char)('A' + i % 26)}{(char)('A' + i % 26)}{(char)('A' + i % 26)}{(char)('A' + i % 26)}{i + 1:D5}",
                    //Purchase date should be before created at date and most of the values of deleted at should be null
                    PurchaseDate = DateTime.Now.AddDays(-i),
                    CreatedAt = DateTime.Now.AddDays(-i),
                    UpdatedAt = null,
                    DeletedAt = i % 10 == 0 ? DateTime.Now.AddDays(-i) : null
                });
            }
            modelBuilder.Entity<Asset>()
                .Property(a => a.PurchaseCost)
                .HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<Asset>().HasData(assets);

            //seed work items
            var workItems = new List<WorkItem>();
            for (int i = 0; i < 400; i++)
            {
                workItems.Add(new WorkItem
                {
                    WorkItemId = Guid.NewGuid(),
                    Title = $"WorkItem {i + 1}",
                    Description = $"Description for WorkItem {i + 1}",
                    Status = (WorkItemStatus)(i % Enum.GetValues(typeof(WorkItemStatus)).Length),
                    Priority = (Priority)(i % Enum.GetValues(typeof(Priority)).Length),
                    Category = (TicketCategory)(i % Enum.GetValues(typeof(TicketCategory)).Length),
                    CreatorUserID = null, // Set CreatorUserID as null for now
                    AssetId = assetGuids[i % 70], // Use Asset ID
                    CreatedAt = DateTime.Now.AddDays(-i)
                });
            }
            modelBuilder.Entity<WorkItem>().HasData(workItems);

            // Seed Tickets (250 entries)
            // Have some tickets have closed and completed dates
            // Must have completed before being closed
            // Some tickets can lack both the closed and completed dates
            var tickets = new List<Ticket>();
            var ticketsUsersIds = new List<string>()
            {
                "auth0|65b7dee72e02f54da98cd265",
                "auth0|65a4f8d7364ff592a0792a42"
            };
            for (int i = 0; i < 250; i++)
            {
                tickets.Add(new Ticket
                {
                    TicketId = Guid.NewGuid(),
                    Title = $"Ticket {i + 1}",
                    Description = $"Description for Ticket {i + 1}",
                    Status = (TicketStatus)(i % Enum.GetValues(typeof(TicketStatus)).Length),
                    Priority = (Priority)(i % Enum.GetValues(typeof(Priority)).Length),
                    Category = (TicketCategory)(i % Enum.GetValues(typeof(TicketCategory)).Length),
                    AssignedUserID = usersIds[i % 4], // Set AssignedUserID as null for now
                    AssetID = assetGuids[i % 70], // Use Asset ID
                    CompletedAt = i % 2 == 0 ? DateTime.Now.AddDays(-i + 1) : null,
                    ClosedAt = i % 2 == 0 ? DateTime.Now.AddDays(-i + 2) : null,
                    CreatedBy = ticketsUsersIds[i % 2],
                    CreatedAt = DateTime.Now.AddDays(-i)
                });
            }
            modelBuilder.Entity<Ticket>().HasData(tickets);
        }
    }
    
}
