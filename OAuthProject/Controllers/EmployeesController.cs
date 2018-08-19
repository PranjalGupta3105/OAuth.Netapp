using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegistrationService.Controllers
{
    
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            using (testEntities entities = new testEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
