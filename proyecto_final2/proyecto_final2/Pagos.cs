using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_final2
{
    public class Pagos
    {
        string idgasto;
        string descripcion;
        int importe;
        string tipoReparto;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
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

        public string Idgasto
        {
            get
            {
                return idgasto;
            }

            set
            {
                idgasto = value;
            }
        }
    }
}