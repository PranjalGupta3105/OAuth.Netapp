using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace RegistrationService.Controllers
{
    public class AuthenticationController : ApiController
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("api/Authentication/forall")]
        public IHttpActionResult Get()
        {
            return Ok("Now Server Time is:" + DateTime.Now.ToString());
        }
        [Authorize]
        [HttpGet]
        [Route("api/Authentication/authenticate")]
        public IHttpActionResult GetForAuthenticate()
        {
            var identity = (ClaimsIdentity)User.Identity;
            return Ok("Hello " + identity.Name);
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("api/Authentication/authorize")]
        public IHttpActionResult GetForAdmin()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var roles = identity.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value);
            return Ok("Hello " + identity.Name+"Role: "+string.Join(",",roles.ToList()));
        }
    }
}
