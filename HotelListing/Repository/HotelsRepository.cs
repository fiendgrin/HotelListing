using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {

        private readonly HotelListingDbContext _context;
        public HotelsRepository(HotelListingDbContext hotelListingDbContext) : base(hotelListingDbContext)
        {
            _context = hotelListingDbContext;
        }

        public async Task<Hotel> GetDetails(int id)
        {
            return await _context.Hotels.Include(h => h.Country)
                .FirstOrDefaultAsync(c => c.Id == id); ;
        }
    }
}
