using EjercicioLinq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.Logic
{
    public class ProductsLogic : BaseLogic
    {
        //Ejercicio2 Query para devolver todos los productos sin stock
        public List<Products> ReturnProductsStockless()
        {   
            //Method Sintax
            //return context.Products.Where(p => p.UnitsInStock != 0).ToList();
            //Query Sintax
            var query = from customers in context.Products
                        where customers.UnitsInStock == 0
                        select customers;
            return query.ToList();
        }

        //Ejercicio 3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad
        public List<Products> ReturnProductsWithStockAndLessThanThreeCost()
        {
            //Method Sintax
            //return context.Products.Where(p => p.UnitsInStock != 0 && p.UnitPrice < 3).ToList();
            //Query Sintax
            var query = from customers in context.Products
                        where customers.UnitsInStock != 0 && customers.UnitPrice < 3
                        select customers;
            return query.ToList();
        }

        //Ejercicio 5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789
        public Products ReturnFirstProductNotNullAndIdEquals789()
        {
            //Method Sintax
            return context.Products.FirstOrDefault(p => p.ProductID == 789);
        }

        //Ejercicio 9. Query para devolver lista de productos ordenados por nombre

        public List<Products> ReturnProductsOrderByName()
        {
            //Method Sintax
            /*
            return context.Products.OrderBy(c => c.ProductName)
                                .ToList();
            */
            //Query Sintax
            
            var query = from customers in context.Products
                        orderby customers.ProductName
                        select customers;
            return query.ToList();
        }

        //Ejercicio 10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.

        public List<Products> ReturnProductsOrderDescByUnitStock()
        {
            //Method Sintax
            /*
            return context.Products.OrderByDescending(c => c.UnitsInStock)
                                .ToList();
            */
            //Query Sintax

            var query = from customers in context.Products
                        orderby customers.UnitsInStock descending
                        select customers;
            return query.ToList();
        }

        //Ejercicio 11. Query para devolver las distintas categorías asociadas a los productos

        public List<Products> ReturnDistinctProductCategories()
        {
            //Method Sintax
            /*
            return context.Products.OrderByDescending(c => c.UnitsInStock)
                                .ToList();
            */
            //Query Sintax

            var query = from customers in context.Products
                        orderby customers.UnitsInStock descending
                        select customers;
            return query.ToList();
        }

        //Ejercicio 12.  Query para devolver el primer elemento de una lista de productos

        public List<Products> ReturnFirstProduct()
        {
            //Method Sintax
            
            return context.Products.Take(1)
                                .ToList();
            
            //Query Sintax

            var query = from customers in context.Products
                        select customers;
            return query.Take(1).ToList();
        }

    }
}
