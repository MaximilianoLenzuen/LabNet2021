using EjercicioMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMVC.Logic
{
    interface ICRUDLogic<T>
    {
        List<T> ObtainData();
        void Add(T toAdd);
        void Delete(int id);
    }
}
