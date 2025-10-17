using Microsoft.EntityFrameworkCore;
using TravelCompanionAPIs.Models;

class APIContext : DbContext
{
    public APIContext(DbContextOptions<APIContext> options) 
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    Id = 1,
                    Destination = "Ho Chi Minh",
                    StartDate = DateTime.Parse("1989-2-12"),
                    EndDate = DateTime.Parse("1989-2-12"),
                    Preference = "ABC",
                    Budget = 10000
                },
                new Trip
                {
                    Id = 2,
                    Destination = "Ho Chi Minh",
                    StartDate = DateTime.Parse("1989-2-12"),
                    EndDate = DateTime.Parse("1989-2-12"),
                    Preference = "ABC",
                    Budget = 10000
                }
            );
    }

    public DbSet<Trip> Trips => Set<Trip>(); 
    public DbSet<ItineraryItem> ItineraryItems => Set<ItineraryItem>();
}