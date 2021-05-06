using EjercicioEntity.Data;
using EjercicioEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntity.Logic
{
    public class OrdersLogic : BaseLogic , ICRUDLogic<Orders>
    {

        public string ObtainData()
        {
            StringBuilder sb = new StringBuilder();
            var aux = context.Orders.ToList();
            if(aux != null)
            {
                foreach (Orders item in aux)
                {
                    sb.AppendLine($"El ID del customer es: {item.CustomerID} y va hacia: {item.ShipAddress}");
                }
            }
            return sb.ToString();
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

        public void Update(Orders entity,string shipAddress)
        {
            var orderUpdate = context.Orders.Find(entity.OrderID);
            orderUpdate.ShipAddress = shipAddress;
            context.SaveChanges();
        }

        public Orders GetObject(int id)
        {
            return context.Orders.Find(id);
        }

    }
}
