using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace standard_api.Controllers
{
    [Route("api/settings")]
    public class SettingsController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] {
                ConfigurationManager.AppSettings["setting-test"],
                ConfigurationManager.ConnectionStrings["connection-test"].ConnectionString,
                "value2" };
        }
    }
}