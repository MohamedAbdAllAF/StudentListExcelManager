using StudentListExcelManager.Models;

namespace StudentListExcelManager.IServices
{
    public interface ILocationService
    {
        Task<List<Country>> GetCountriesAsync();
        Task<List<Governorate>> GetGovernoratesByCountryIdAsync(int countryId);
        Task<List<City>> GetCitiesByGovernorateIdAsync(int governorateId);
    }
}
