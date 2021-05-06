using EjercicioEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntity.Logic
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

        public string ObtainData()
        {
            StringBuilder sb = new StringBuilder();
            var aux = context.Employees.ToList();
            if (aux != null)
            {
                foreach (Employees item in aux)
                {
                    sb.AppendLine($"Empleado: {item.FirstName} {item.LastName}, direccion {item.Address}");
                }
            }
            return sb.ToString();
        }

        public void Update(Employees entity,string direccion)
        {
            var orderUpdate = context.Employees.Find(entity.EmployeeID);
            orderUpdate.Address = direccion;
            context.SaveChanges();

        }

        public Employees GetObject(int id)
        {
            return context.Employees.Find(id);
        }
    }
}
