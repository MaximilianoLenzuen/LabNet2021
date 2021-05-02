using EjercicioEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntity.Logic
{
    interface ICRUDLogic<T>
    {
        string ObtainData();
        void Add(T toAdd);
        void Delete(int id);
        void Update(T entity,string address);
    }
}
