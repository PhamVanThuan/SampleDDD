using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample.Api.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("I'm in secure");
        }
    }
}
