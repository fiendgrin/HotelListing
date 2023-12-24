using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
