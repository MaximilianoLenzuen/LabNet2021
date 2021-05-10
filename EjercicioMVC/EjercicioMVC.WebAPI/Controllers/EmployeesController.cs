using EjercicioMVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EjercicioMVC.WebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeesLogic empLogic = new EmployeesLogic();
        // GET: api/Employees
        public IEnumerable<EmployeesView> Get()
        {
            var employees = empLogic.ObtainData();

            List<EmployeesView> empView = employees.Select(e => new EmployeesView
            {
                ID = e.EmployeeID,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Address = e.Address,
                City = e.City

            }).ToList();
            return empView;
        }

        // GET: api/Employees/5
        public EmployeesView Get(int id)
        {
            var retorno = empLogic.GetObject(id);
            EmployeesView empView = new EmployeesView
            {
                ID = retorno.EmployeeID,
                FirstName = retorno.FirstName,
                LastName = retorno.LastName,
                Address = retorno.Address,
                City = retorno.City
            };
            return empView;
        }

        // POST: api/Employees
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employees/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
        }
    }
}
