using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_final2
{
    public class DatosPropietarios
    {
        string nombre;
        string nit;
        string correo;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }
    }
}