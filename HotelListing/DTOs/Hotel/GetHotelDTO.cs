using HotelListing.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.DTOs.Hotel
{
    public class GetHotelDTO : BaseHotelDTO
    {

        public int Id { get; set; }

        public Data.Country? Country { get; set; }
    }
}
