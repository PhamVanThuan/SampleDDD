using System.Collections.Generic;
using Sample.Data.Abstractions;
using Sample.Entities;
using Sample.Services.Abstractions;

namespace Sample.Services
{
    public class CountryService: ICountryService
    {
        private ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IEnumerable<Country> GetAllCountries()
        {
            return _countryRepository.GetCountries();
        }
    }
}