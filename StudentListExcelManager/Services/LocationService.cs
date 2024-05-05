using StudentListExcelManager.IServices;
using StudentListExcelManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListExcelManager.Services
{
    public class LocationService : ILocationService
    {
        
        public Task<List<Country>> GetCountriesAsync()
        {
            return Task.FromResult(GetCountries());
        }
        public Task<List<City>> GetCitiesByGovernorateIdAsync(int governorateId)
        {
            // Dummy implementation to return a list of cities asynchronously
            List<City> cities = new List<City>
            {
                new City { Id = 1, Name = "City 1", GovernorateId = 1 },
                new City { Id = 2, Name = "City 2", GovernorateId = 1 },
                new City { Id = 3, Name = "City 3", GovernorateId = 2 },
                // Add more dummy data as needed
            };

            // Filter cities by governorate Id
            var filteredCities = cities.Where(city => city.GovernorateId == governorateId).ToList();

            return Task.FromResult(filteredCities);
        }

        public Task<List<Governorate>> GetGovernoratesByCountryIdAsync(int countryId)
        {
            // Dummy implementation to return a list of governorates asynchronously
            List<Governorate> governorates = new List<Governorate>
            {
                new Governorate { Id = 1, Name = "Governorate 1", CountryId = 1 },
                new Governorate { Id = 2, Name = "Governorate 2", CountryId = 1 },
                new Governorate { Id = 3, Name = "Governorate 3", CountryId = 2 },
                // Add more dummy data as needed
            };

            // Filter governorates by country Id
            var filteredGovernorates = governorates.Where(gov => gov.CountryId == countryId).ToList();

            return Task.FromResult(filteredGovernorates);
        }

        public List<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country { Id = 1, Name = "USA" },
                new Country { Id = 2, Name = "Canada" },
                new Country { Id = 3, Name = "UK" }
            };
        }
    }
}
