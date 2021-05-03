using EjercicioLinq.Entities;
using EjercicioLinq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic customers = new CustomersLogic();
            ProductsLogic products = new ProductsLogic();
            //Ejercicio 1 test
            var query1 = customers.ReturnCustomer();
            //Ejercicio 2 test
            var query2 = products.ReturnProductsStockless();
            //Ejercicio 3 test
            var query3 = products.ReturnProductsWithStockAndLessThanThreeCost();
            //Ejercicio 4 test
            var query4 = customers.ReturnCustomersFromWashington();
            //Ejercicio 5 test 
            var query5 = products.ReturnFirstProductNotNullAndIdEquals789();
            //Ejercicio 6 test 
            var query6 = customers.ReturnNamesFromCustomers();
            //Ejercicio 7 test
            var query7 = customers.ReturnJoinCustomers();
            //Ejercicio 8 test 
            var query8 = customers.ReturnFirstThreeCustomersFromWashington();
            //Ejercicio 9 test
            var query9 = products.ReturnProductsOrderByName();
            //Ejercicio 10 test
            var query10 = products.ReturnProductsOrderDescByUnitStock();
            //Ejercicio 11 test
            var query11 = products.ReturnDistinctProductCategories();
            //Ejercicio 12 test
            var query12 = products.ReturnFirstProduct();
            //Ejercicio 13 test REVISAR
            //var query13 = customers.ReturnAmountOfOrders();

            Console.ReadKey();
        }
    }
}
