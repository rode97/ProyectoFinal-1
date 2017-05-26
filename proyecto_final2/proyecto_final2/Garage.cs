using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto_final2
{
    public class Garage
    {
        string abierta; //abiertacerrada
        string bodega;

        public string Abierta
        {
            get
            {
                return abierta;
            }

            set
            {
                abierta = value;
            }
        }

        public string Bodega
        {
            get
            {
                return bodega;
            }

            set
            {
                bodega = value;
            }
        }
    }
}