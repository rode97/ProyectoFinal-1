using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_final2
{
    public class Propiedad
    {
        string tipo;
        string codigo;
        int metros;
        string propietario;
        List<string> gastos;

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public int Metros
        {
            get
            {
                return metros;
            }

            set
            {
                metros = value;
            }
        }

        public string Propietario
        {
            get
            {
                return propietario;
            }

            set
            {
                propietario = value;
            }
        }

        public List<string> Gastos
        {
            get
            {
                return gastos;
            }

            set
            {
                gastos = value;
            }
        }
    }
}