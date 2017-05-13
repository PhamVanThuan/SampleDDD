using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Entities;

namespace Sample.Services.Abstractions
{
    public interface ICountryService
    {
        IEnumerable<Country> GetAllCountries();
    }
}
