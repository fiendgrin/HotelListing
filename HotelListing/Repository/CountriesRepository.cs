using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext hotelListingDbContext) : base(hotelListingDbContext)
        {
            _context = hotelListingDbContext;
        }

        public async Task<Country> GetDetails(int? id)
        {
            return await _context.Countries.Include(c=>c.Hotels)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
