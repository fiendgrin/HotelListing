using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListing.Data;
using HotelListing.DTOs.Country;
using AutoMapper;
using HotelListing.Contracts;
using System.Diagnostics.Metrics;

namespace HotelListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ICountriesRepository _countriesRepository;

        public CountriesController(IMapper mapper, ICountriesRepository countriesRepository)
        {
            _mapper = mapper;
            _countriesRepository = countriesRepository;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            if (await _countriesRepository.GetAllAsync() == null)
            {
                return NotFound();
            }

            IEnumerable<Country> countries = await _countriesRepository.GetAllAsync();
            IEnumerable<GetCountryDTO> getCountryDTOs = _mapper.Map<IEnumerable<GetCountryDTO>>(countries);
            return Ok(getCountryDTOs);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDTO>> GetCountry(int id)
        {
            if (await _countriesRepository.GetAllAsync() == null)
            {
                return NotFound();
            }
            var country = await _countriesRepository.GetDetails(id);

            if (country == null)
            {
                return NotFound();
            }

            CountryDTO countryDTO = _mapper.Map<CountryDTO>(country);

            return countryDTO;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, UpdateCountryDTO updateCountryDTO)
        {
            if (id != updateCountryDTO.Id)
            {
                return BadRequest();
            }

            var country = await _countriesRepository.GetAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            _mapper.Map(updateCountryDTO, country);

            try
            {
                await _countriesRepository.UpdateAsync(country);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CountryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDTO createCountryDTO)
        {
            if (await _countriesRepository.GetAllAsync() == null)
            {
                return Problem("Entity set 'HotelListingDbContext.Countries'  is null.");
            }

            Country DbCountry = _mapper.Map<Country>(createCountryDTO);

           await _countriesRepository.AddAsync(DbCountry);

            return CreatedAtAction("GetCountry", new { id = DbCountry.Id }, DbCountry);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int? Id)
        {
            var country = await _countriesRepository.GetAsync(Id);
            if (country == null)
            {
                return NotFound();
            }

            if (country == null)
            {
                return NotFound();
            }

            await _countriesRepository.DeleteAsync(Id);

            return NoContent();
        }

        private async Task<bool> CountryExists(int? Id)
        {
            return await _countriesRepository.Exists(Id);
        }
    }
}
