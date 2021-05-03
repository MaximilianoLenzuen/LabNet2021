using EjercicioLinq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.Logic
{
    public class CustomersLogic : BaseLogic
    {
        //Ejercicio 1. Query para devolver objeto customer
        public List<Customers> ReturnCustomer()
        {
            //Method sintax
            //return context.Customers.ToList();
            //Query sintax
            var query = from customers in context.Customers
                        select customers;
            return query.ToList();
        }

        //Ejercicio 4. Query para devolver todos los customers de Washington
        public List<Customers> ReturnCustomersFromWashington()
        {
            //Method sintax
            /*
             return context.Customers.Where(c => c.Region == "WA")
                                .ToList();
            */
            //Query sintax
            
            var query = from customers in context.Customers
                        where customers.Region == "WA"
                        select customers;
            return query.ToList();
            
        }

        /*
        //Ejercicio 6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.
        public List<Customers> ReturnNamesFromCustomers()
        {
            //Method sintax
            //return context.Customers.Select(x => new { NameLower = x.ContactName.ToLower(), NameUpper = x.ContactName.ToUpper() }).ToList();
            //Query sintax
            
            var query = from customers in context.Customers
                        select new
                        {
                            NameLower = customers.ContactName.ToLower(),
                        };
            return (List<Customers>)query;
        }
        */

        //Ejercicio 7. Query para devolver Join entre Customers y Orders donde los customers sean de
        //Washington y la fecha de orden sea mayor a 1/1/1997.

        
        public List<Customers> ReturnJoinCustomers()
        {
            //Method sintax

            //Query sintax

            var query = from customers in context.Customers
                        join orders in context.Orders
                        on new { customers.Orders }
                           equals new { orders = orders.OrderID }
                        select new
                        {
                            customers.ContactName,
                            orders.OrderDate()
                        };
            return query.ToList();
            
        }
         
        

        //Ejercicio 8 Query para devolver los primeros 3 Customers de Washington
        public List<Customers> ReturnFirstThreeCustomersFromWashington()
        {
            //Method sintax
            /*return context.Customers.Where(c => c.Region == "WA")
                                .Take(3)
                                .ToList();
            */
            //Query sintax

            var query = from customers in context.Customers
                        where customers.Region == "WA"
                        select customers;
            return query.Take(3).ToList();

        }

        //Ejercicio 13 Query para devolver los customer con la cantidad de ordenes asociadas

        public List<Customers> ReturnAmountOfOrders()
        {
            //Method sintax
            /*return context.Customers.Where(c => c.Region == "WA")
                                .Take(3)
                                .ToList();
            */
            //Query sintax

            var query = from customers in context.Customers
                        join orders in context.Orders
                        on new {customers.Orders }
                          equals new { orders.OrderID}
                        select new
                        {
                            customers.
                        }
            return query.ToList();

        }
    }
}
