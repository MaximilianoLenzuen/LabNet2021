using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Transporte
    {
        #region Atributos

        private int pasajeros;

        #endregion

        #region Propiedades
        public int Pasajeros
        {
            get { return pasajeros; }
        }
        #endregion

        #region Constructores
        public Transporte(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        #endregion

        #region Metodos Abstractos
        public abstract string Avanzar();

        public abstract string Detenerse();

        #endregion
    }
}
