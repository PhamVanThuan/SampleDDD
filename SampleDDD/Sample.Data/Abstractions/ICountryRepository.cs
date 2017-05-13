using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Entities;

namespace Sample.Data.Abstractions
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();
    }
}
