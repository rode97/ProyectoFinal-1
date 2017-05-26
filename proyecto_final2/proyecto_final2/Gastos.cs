using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_final2
{
    public class Gastos
    {
        string identificacion;
        string nombre;
        string tipoReparto;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

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

        public string TipoReparto
        {
            get
            {
                return tipoReparto;
            }

            set
            {
                tipoReparto = value;
            }
        }
    }
}