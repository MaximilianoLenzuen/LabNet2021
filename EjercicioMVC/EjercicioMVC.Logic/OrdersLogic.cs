using EjercicioMVC.Data;
using EjercicioMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    public class OrdersLogic : BaseLogic , ICRUDLogic<Orders>
    {

        public List<Orders> ObtainData()
        {
            return context.Orders.ToList();
        }

        public void Add(Orders toAdd)
        {
            context.Orders.Add(toAdd);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletingOrder = context.Orders.Find(id);
            context.Orders.Remove(deletingOrder);
            context.SaveChanges();
        }

        public void Update(int id,string shipAddress, string idCustomer, int idEmployee )
        {
            var orderUpdate = context.Orders.Find(id);
            orderUpdate.ShipAddress = shipAddress;
            orderUpdate.CustomerID = idCustomer;
            orderUpdate.EmployeeID = idEmployee;
            context.SaveChanges();
        }

        public Orders GetObject(int id)
        {
            return context.Orders.Find(id);
        }

    }
}
