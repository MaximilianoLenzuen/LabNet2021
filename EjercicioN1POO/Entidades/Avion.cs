using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Transporte
    {
        #region Constructor
        public Avion(int pasajeros) : base(pasajeros)
        {

        }
        #endregion

        #region Metodos
        public override string Avanzar()
        {
            return "El avion avanza por el aire...";
        }

        public override string Detenerse()
        {
            return "El avion no se puede detener en el aire...";
        }
        #endregion
    }
}
