using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.Entities
{
    public class CustomerOrderAmount
    {
        public Customers Customer { get; set; }

        public int Amount { get; set; }
    }
}
