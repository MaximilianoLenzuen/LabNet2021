using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntity.Common
{
    public class ViewLogic
    {
        public static string CargarMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Menu: ");
            sb.AppendLine("1) Ingrese orden ");
            sb.AppendLine("2) Ingrese empleado ");
            sb.AppendLine("3) Modificar direccion del Empleado ");
            sb.AppendLine("4) Modificar direccion de una orden");
            sb.AppendLine("5) Eliminar orden ");
            sb.AppendLine("6) Eliminar empleado ");
            sb.AppendLine("7) Listar empleados ");
            sb.AppendLine("8) Listar Ordenes ");
            sb.AppendLine("9) Salir ");
            return sb.ToString();
        }
    }
}
