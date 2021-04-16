using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Transporte 
    {
        #region Constructores
        public Automovil(int pasajeros) : base(pasajeros)
        {

        }
        #endregion

        #region Metodos
        public override string Avanzar()
        {
            return "El automovil avanza...";
        }

        public override string Detenerse()
        {
            return "El automovil puede detenerse...";
        }

        public override string MostrarDatos(int index)
        {
            return $"Automovil {index}: {this.Pasajeros} pasajeros";
        }
        #endregion
    }
}
