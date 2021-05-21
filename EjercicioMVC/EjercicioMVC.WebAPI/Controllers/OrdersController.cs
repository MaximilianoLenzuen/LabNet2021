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
        public IHttpActionResult Post([FromBody]OrdersView ord)
        {
            try
            {
                Orders order = new Orders
                {
                    EmployeeID = ord.EmployeeID,
                    CustomerID = ord.IdCustomer,
                    ShipAddress = ord.Address,
                };
                orderLogic.Add(order);
                return Ok();
            }
            catch (Exception ex) 
            {
                return InternalServerError(ex);
            }

        }

        // PUT: api/Orders/5
        public IHttpActionResult Put(int id, [FromBody]OrdersView ord)
        {
            try
            {
                orderLogic.Update(id, ord.Address, ord.IdCustomer, (int)ord.EmployeeID);
                return Ok();

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // DELETE: api/Orders/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                orderLogic.Delete(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
