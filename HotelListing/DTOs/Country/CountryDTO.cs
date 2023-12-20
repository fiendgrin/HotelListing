using HotelListing.Data;
using HotelListing.DTOs.Hotel;

namespace HotelListing.DTOs.Country
{
    public class CountryDTO : BaseCountryDTO
    {
        public int Id { get; set; }

        public IList<HotelDTO>? Hotels { get; set; }
    }
}
