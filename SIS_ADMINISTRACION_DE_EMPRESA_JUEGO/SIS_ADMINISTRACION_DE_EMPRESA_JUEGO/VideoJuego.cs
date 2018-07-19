using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    class VideoJuego
    {
        #region Miembros Privados

        private string m_strNombre;
        private int m_intCantidad;
        private double m_dblPrecio;

        #endregion

        #region Propiedades Publicas

        public string Nombre
        {
            get { return m_strNombre; }
            set { m_strNombre = value; }
        }

        public double PrecioPorUnidad
        {
            get { return m_dblPrecio; }
            set { m_dblPrecio = value; }
        }

        public int Cantidad
        {
            get { return m_intCantidad; }
            set { m_intCantidad = value; }
        }
        
        #endregion    

    }
}
