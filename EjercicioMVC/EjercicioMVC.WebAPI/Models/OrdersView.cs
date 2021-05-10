using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioMVC.WebAPI
{
    public class OrdersView
    {
        public string IdCustomer { get; set; }
        public string Address { get; set; }
        public int OrderID { get; set; }
        public int? EmployeeID { get; set; }

    }
}