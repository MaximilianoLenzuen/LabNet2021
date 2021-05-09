using EjercicioMVC.Entities;
using EjercicioMVC.Logic;
using EjercicioMVC.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioMVC.MVC.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        OrdersLogic ordersLogic = new OrdersLogic();
        public ActionResult ListOrders()
        {
            var ordersList = ordersLogic.ObtainData();

            List<OrdersView> ordView = ordersList.Select(o => new OrdersView
            {
                EmployeeID = o.EmployeeID,
                IdCustomer = o.CustomerID,
                Address = o.ShipAddress,
                OrderID = o.OrderID
       
            }).ToList();
            return View(ordView);
        }

        public ActionResult AddOrders()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOrders(OrdersView orderView)
        {
            try
            {
                var orderToAdd = new Orders
                {
                    CustomerID = orderView.IdCustomer,
                    EmployeeID = orderView.EmployeeID,
                    ShipAddress = orderView.Address,
                };
                if(orderView.OrderID == 0)
                {
                    ordersLogic.Add(orderToAdd);
                }
                else
                {
                    ordersLogic.Update(orderView.OrderID, orderView.Address, orderView.IdCustomer, (int)orderView.EmployeeID);
                }
                return RedirectToAction("ListOrders","Orders");
            }
            catch (Exception)
            {
                return RedirectToAction("IndexEmployees","Error");
            }
        }

        public ActionResult DeleteOrder(int id)
        {
            try
            {
                ordersLogic.Delete(id);
                return RedirectToAction("IndexOrders","Orders");
            }
            catch (Exception)
            {
                return RedirectToAction("IndexOrders", "Error");
            }
        }

        
    }
}