using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Services.Abstractions;

namespace Sample.Web.Controllers
{
    public class DefaultController : Controller
    {
        private ICountryService _countryService;

        public DefaultController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // GET: Default
        public ActionResult Index()
        {
            var countries = _countryService.GetAllCountries(); 
            return View(countries);
        }
    }
}