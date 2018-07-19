using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    class JUEGO
    {
        private string _STRNOMBRE;

        public string NOMBRE
        {
            get { return _STRNOMBRE; }
            set { _STRNOMBRE = value; }
        }

        private double _PRECIO;

        public double PRECIOPORUNIDAD
        {
            get { return _PRECIO; }
            set { _PRECIO = value; }
        }

        private int _intCANTIDAD;

        public int CANTIDAD
        {
            get { return _intCANTIDAD; }
            set { _intCANTIDAD = value; }
        }
            

    }
}
