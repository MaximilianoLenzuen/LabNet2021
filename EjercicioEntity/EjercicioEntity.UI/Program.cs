using EjercicioEntity.Entities;
using EjercicioEntity.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntity.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdersLogic orders = new OrdersLogic();
            EmployeesLogic employees = new EmployeesLogic();
            int orderEmpID;
            string orderCustomerID;
            string orderShipAddress;
            string empAddress;
            string empCity;

            // Testeo con ordenes
            //Pido datos
            /*
            Console.WriteLine("Ingrese el id del empleado a cargo de la orden");
            try
            {
                orderEmpID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Random r = new Random();
                orderEmpID = r.Next(1, 9);
                Console.WriteLine("Caracter invalido, se le asigno uno aleatoriamente");
            }
            Console.WriteLine("Ingrese el id del customer EJ: TORTU");
            orderCustomerID = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion a la que va");
            orderShipAddress = Console.ReadLine();
            // Intento utilizar el Insert Update Delete
            try
            {
                Orders order = new Orders
                {
                    EmployeeID = orderEmpID,
                    CustomerID = orderCustomerID,
                    ShipAddress = orderShipAddress
                };
                orders.Add(order);
                Console.WriteLine("Orden agregada!");
                Console.ReadKey();
                Console.WriteLine("Se presento un problema con la direccion, elija una nuevaa");
                orders.Update(order, Console.ReadLine());
                Console.WriteLine(orders.ObtainData());
                Console.ReadKey();
                Console.WriteLine("Se anulo la orden. Se elimina del sistema");
                orders.Delete(order.OrderID);

            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error");
            }
            // Muestro la info y verifico el resultado obtenido
            Console.WriteLine("Presione una tecla para mostrar todas las ordenes");
            Console.ReadKey();
            Console.WriteLine(orders.ObtainData());
            */
            //Testeo con empleados
            //Pido los datos
            Console.WriteLine("Ahora ingresamos un nuevo empleado");
            Console.WriteLine("Ingrese la direccion del empleado");
            empAddress = Console.ReadLine();
            Console.WriteLine("Ingrese la ciudad");
            empCity = Console.ReadLine();
            // Intento utilizar el Insert Update Delete
            try
            {
                Employees employee = new Employees
                {
                    Address = empAddress,
                    City = empCity,
                    LastName = "Generico",
                    FirstName = "Generico"
                };
                employees.Add(employee);
                Console.WriteLine("Empleado agregada!");
                Console.ReadKey();
                Console.WriteLine("Se presento un problema con la direccion, elija una nuevaa");
                employees.Update(employee, Console.ReadLine());
                Console.ReadKey();
                Console.WriteLine("Se anulo el empleado. Se elimina del sistema");
                employees.Delete(employee.EmployeeID);
            }
            catch (Exception)
            {
                Console.WriteLine("Hubo un error");
            }
            // Muestro la info y verifico el resultado obtenido
            Console.WriteLine("Presione una tecla para mostrar todas las empleados");
            Console.ReadKey();
            Console.WriteLine(employees.ObtainData());
            Console.ReadKey();

        }


    }
}

