﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.DTOs.Hotel
{
    public class BaseHotelDTO
    {
        [Required]
        public string Name { get; set; }
        public string? Address { get; set; }
        public double? Rating { get; set; }
    }
}
