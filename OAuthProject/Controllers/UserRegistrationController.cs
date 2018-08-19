//using OAuthProject.Services;
//using RegistrationService.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Web.Http;

//namespace RegistrationService.Controllers
//{
//    public class UserRegistrationController : ApiController
//    {
//        [Route("api/Registration")]
//        [HttpPost]
//        public IHttpActionResult RegisterUser([FromBody] UserDetails userDetails)
//        {
//            SqlConnectionProvider sqlconn = new SqlConnectionProvider();
//            var message = sqlconn.EstablishConnection("abc", "dbo.Employees",userDetails);
//            //HttpResponseMessage resp = new HttpResponseMessage();
//            return Ok(message);
//        }
//    }
//}
