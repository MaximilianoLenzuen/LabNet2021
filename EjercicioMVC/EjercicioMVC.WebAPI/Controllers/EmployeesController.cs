using EjercicioMVC.Entities;
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
        public IHttpActionResult Post([FromBody]EmployeesView emp)
        {
            try
            {
                Employees employee = new Employees
                {
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    Address = emp.Address,
                    City = emp.City
                };
                empLogic.Add(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        // PUT: api/Employees/5
        public IHttpActionResult Patch(int id, [FromBody] EmployeesView emp)
        {
            try
            {
                empLogic.Update(id, emp.Address, emp.FirstName, emp.LastName, emp.City);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        // DELETE: api/Employees/5
        public IHttpActionResult Delete(int id)
        {

            try
            {
                empLogic.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
