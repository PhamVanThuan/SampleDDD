using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Core.Repository;
using Sample.Data.Abstractions;
using Sample.Entities;

namespace Sample.Data.Repositories
{
    public class CountryRepository : EntityFrameworkRepository<SampleDbContext>, ICountryRepository
    {
        public CountryRepository(SampleDbContext context) : base(context)
        {
        }

        public IEnumerable<Country> GetCountries()
        {
            var result = context.Countries.ToList();
            return result;
        }
    }
}
