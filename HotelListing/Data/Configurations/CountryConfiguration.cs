using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
