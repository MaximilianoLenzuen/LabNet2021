using EjercicioMVC.Common;
using EjercicioMVC.Entities;
using EjercicioMVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdersLogic orders = new OrdersLogic();
            EmployeesLogic employees = new EmployeesLogic();
            int option;
            int orderEmpID;
            string orderCustomerID;
            string orderShipAddress;
            string empName;
            int idChange;
            int idDelete;
            string empLastName;
            string empAddress;
            string empCity;
            do
            {
                Console.WriteLine(ViewLogic.CargarMenu());
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Ingrese el id del customer EJ: TORTU");
                            orderCustomerID = Console.ReadLine();
                            Console.WriteLine("Ingrese la direccion a la que va");
                            orderShipAddress = Console.ReadLine();
                            Console.WriteLine("Ingrese el id del empleado a cargo de la orden");
                            orderEmpID = int.Parse(Console.ReadLine());
                            Orders order1 = new Orders
                            {
                                EmployeeID = orderEmpID,
                                CustomerID = orderCustomerID,
                                ShipAddress = orderShipAddress
                            };
                            orders.Add(order1);
                            Console.WriteLine("Orden agregada!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Se ingresó un dato no valido!, vuelva a intentar");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre");
                        empName = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido");
                        empLastName = Console.ReadLine();
                        Console.WriteLine("Ingrese la direccion del empleado");
                        empAddress = Console.ReadLine();
                        Console.WriteLine("Ingrese la ciudad");
                        empCity = Console.ReadLine();
                        try
                        {
                            Employees employee = new Employees
                            {
                                Address = empAddress,
                                City = empCity,
                                LastName = empLastName,
                                FirstName = empName
                            };
                            employees.Add(employee);
                            Console.WriteLine("Empleado agregada!");
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Hubo un error");
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Ingrese el id del empleado a modificar");
                            idChange = int.Parse(Console.ReadLine());
                            Employees employees2 = employees.GetObject(idChange);
                            Console.WriteLine("Ingrese la nueva direccion del empleado");
                            employees.Update(employees2, Console.ReadLine());
                            Console.WriteLine("Direccion modificada!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error");
                        }

                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Ingrese el id de la orden a modificar");
                            idChange = int.Parse(Console.ReadLine());
                            Orders order = orders.GetObject(idChange);
                            Console.WriteLine("Ingrese la nueva direccion hacia donde va la orden");
                            orders.Update(order, Console.ReadLine());
                            Console.WriteLine("Direccion modificada!");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error");
                        }

                        break;
                    case 5:
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Ingrese el id del empleado a eliminar");
                            idDelete = int.Parse(Console.ReadLine());
                            employees.Delete(idDelete);
                            Console.WriteLine("Empleado eliminado");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error al eliminar");
                        }
                        break;
                    case 6:
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Ingrese el id de orden a eliminar");
                            idDelete = int.Parse(Console.ReadLine());
                            orders.Delete(idDelete);
                            Console.WriteLine("Orden eliminada");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error al eliminar");
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine(employees.ObtainData()); 
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine(orders.ObtainData()); 
                        break;
                    case 9:
                        Console.WriteLine("Gracias por utilizar el programa");
                        break;
                }
            } while (option != 9);
        }
    }
}

