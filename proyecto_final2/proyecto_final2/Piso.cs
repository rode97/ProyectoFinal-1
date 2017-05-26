using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_final2
{
    public class Piso:Propiedad
    {
        string vhvn;
        string habitaciones;

        public string Vhvn
        {
            get
            {
                return vhvn;
            }

            set
            {
                vhvn = value;
            }
        }

        public string Habitaciones
        {
            get
            {
                return habitaciones;
            }

            set
            {
                habitaciones = value;
            }
        }
    }
}