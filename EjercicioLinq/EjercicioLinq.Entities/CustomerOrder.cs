﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLinq.Entities
{
    public class CustomerOrder
    {
        public Customers Customer { get; set; }

        public Orders Order { get; set; }
    }
}
