using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.DTOs.Hotel
{
    public class HotelDTO : BaseHotelDTO
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
    }
}
