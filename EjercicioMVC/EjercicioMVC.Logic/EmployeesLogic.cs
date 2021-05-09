using EjercicioMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class EmployeesLogic : BaseLogic, ICRUDLogic<Employees>
    {
        public void Add(Employees toAdd)
        {
            context.Employees.Add(toAdd);
            context.SaveChanges(); 
        }

        public void Delete(int id)
        {
            var deletingEmployee = context.Employees.Find(id);
            context.Employees.Remove(deletingEmployee);
            context.SaveChanges();
        }

        public List<Employees> ObtainData()
        {
            return context.Employees.ToList();
        }

        public void Update(int id,string direccion,string nombre, string apellido, string ciudad)
        {
            var employeeUpdate = context.Employees.Find(id);
            employeeUpdate.Address = direccion;
            employeeUpdate.FirstName = nombre;
            employeeUpdate.LastName = apellido;
            employeeUpdate.City = ciudad;
            context.SaveChanges();
        }

        public Employees GetObject(int id)
        {
            return context.Employees.Find(id);
        }
    }
}
