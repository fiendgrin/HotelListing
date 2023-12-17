using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Azerbaijan",
                    ShortName = "AZ"

                },
                new Country
                {
                    Id = 2,
                    Name = "Russia",
                    ShortName = "RU"

                },
                new Country
                {
                    Id = 3,
                    Name = "United Kingdom",
                    ShortName = "UK"

                },
                new Country
                {
                    Id = 4,
                    Name = "United States Of America",
                    ShortName = "USA"

                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                  new Hotel
                  {
                      Id = 1,
                      Name = "Trump",
                      Address = "Baku",
                      CountryId = 1,
                      Rating = 4.2

                  },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Radisson",
                     Address = "Moscow",
                     CountryId = 2,
                     Rating = 4.5

                 },
                 new Hotel
                 {
                     Id = 3,
                     Name = "The Cumberland",
                     Address = "London",
                     CountryId = 3,
                     Rating = 4.1

                 },
                 new Hotel
                 {
                     Id = 4,
                     Name = "Rio",
                     Address = "Las-Vegas",
                     CountryId = 4,
                     Rating = 3.6

                 }
                );
        }

    }
}
