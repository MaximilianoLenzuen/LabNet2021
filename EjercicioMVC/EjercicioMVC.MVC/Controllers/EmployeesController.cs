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
    public class EmployeesController : Controller
    {
        // GET: Employees
        EmployeesLogic employeesLogic = new EmployeesLogic();
        public ActionResult ListEmployees()
        {
            var employees = employeesLogic.ObtainData();

            List<EmployeesView> empView = employees.Select(e => new EmployeesView
            {
                ID = e.EmployeeID,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Address = e.Address,
                City = e.City

            }).ToList();
            return View(empView);
        }

        public ActionResult AddEmployees()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployees(EmployeesView empView)
        {
            try
            {
                var empToAdd = new Employees
                {
                    FirstName = empView.FirstName,
                    LastName = empView.LastName,
                    Address = empView.Address,
                    City = empView.City
                };
                if(empView.ID == 0)
                {
                    employeesLogic.Add(empToAdd);
                }
                else
                {
                    employeesLogic.Update(empView.ID, empView.Address, empView.FirstName, empView.LastName, empView.City);
                }
                return RedirectToAction("ListEmployees","Employees");
            }
            catch (Exception)
            {
                return RedirectToAction("IndexEmployees","Error");
            }
        }

        public ActionResult DeleteEmployee(int id)
        {
            try
            {
                employeesLogic.Delete(id);
                return RedirectToAction("ListEmployees","Employees");
            }
            catch (Exception)
            {
                return RedirectToAction("IndexEmployees", "Error");
            }
        }


        
    }
}