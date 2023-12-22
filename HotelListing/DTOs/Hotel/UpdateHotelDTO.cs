namespace HotelListing.DTOs.Hotel
{
    public class UpdateHotelDTO : BaseHotelDTO
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
    }
}
