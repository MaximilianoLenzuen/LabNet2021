using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Logic
    {
        public static void LanzarException()
        {
            throw new Exception();
        }

        public static void LanzarExceptionPropia(string mensaje)
        {
            throw new ExceptionPropia(mensaje);
        }
    }
}
