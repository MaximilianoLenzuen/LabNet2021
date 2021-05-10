using EjercicioMVC.Entities;
using EjercicioMVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace EjercicioMVC.WebAPI.Controllers
{
    public class OrdersController : ApiController
    {
        OrdersLogic orderLogic = new OrdersLogic();
        // GET: api/Orders
        public IEnumerable<OrdersView> Get()
        {
            var retorno = orderLogic.ObtainData();
            List<OrdersView> ordView = retorno.Select(o => new OrdersView
            {
                EmployeeID = o.EmployeeID,
                IdCustomer = o.CustomerID,
                Address = o.ShipAddress,
                OrderID = o.OrderID
            }).ToList();
            return ordView;
        }

        // GET: api/Orders/5
        public OrdersView Get(int id)
        {
            var retorno = orderLogic.GetObject(id);
            OrdersView ordView = new OrdersView
            {
                EmployeeID = retorno.EmployeeID,
                IdCustomer = retorno.CustomerID,
                Address = retorno.ShipAddress,
                OrderID = retorno.OrderID
            };
            return ordView;
        }

        // POST: api/Orders
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Orders/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Orders/5
        public void Delete(int id)
        {
        }
    }
}
