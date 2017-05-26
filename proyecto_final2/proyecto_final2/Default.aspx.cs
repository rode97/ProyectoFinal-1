using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace proyecto_final2
{
    public partial class _Default : Page
    {
        List<Comunidad> listComunidad = new List<Comunidad>();
        List<DatosPropietarios> listDatpropietarios = new List<DatosPropietarios>();
        List<Garage> listGarage = new List<Garage>();
        List<Gastos> listGastos = new List<Gastos>();
        List<Local> listLocal = new List<Local>();
        List<Pagos> listPagos = new List<Pagos>();
        List<Piso> listpiso = new List<Piso>();
        List<Propiedad> listPropiedad = new List<Propiedad>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\Comunidad.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while(leer.Peek() > -1)
            {
                Comunidad comunidadTemp = new Comunidad();
                comunidadTemp.Identificacion = leer.ReadLine();
                comunidadTemp.Nombre = leer.ReadLine();
                comunidadTemp.Poblacion = Convert.ToInt32(leer.ReadLine());

                listComunidad.Add(comunidadTemp);
            }
            leer.Close();
            GridView1.DataSource = listComunidad;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\DatosPropietario.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                DatosPropietarios DatosPropieTemp = new DatosPropietarios();
                DatosPropieTemp.Nombre = leer.ReadLine();
                DatosPropieTemp.Nit = leer.ReadLine();
                DatosPropieTemp.Correo = leer.ReadLine();

                listDatpropietarios.Add(DatosPropieTemp);
            }
            leer.Close();
            GridView2.DataSource = listDatpropietarios;
            GridView2.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\Garage.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Garage garageTemp = new Garage();
                garageTemp.Abierta = leer.ReadLine();
                garageTemp.Bodega = leer.ReadLine();

                listGarage.Add(garageTemp);
            }
            leer.Close();
            GridView3.DataSource = listGarage;
            GridView3.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\Gastos.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Gastos gastosTemp = new Gastos();
                gastosTemp.Identificacion = leer.ReadLine();
                gastosTemp.Nombre = leer.ReadLine();
                gastosTemp.TipoReparto = leer.ReadLine();

                listGastos.Add(gastosTemp);
            }
            leer.Close();
            GridView4.DataSource = listGastos;
            GridView4.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\Local.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Local localTemp = new Local();
                localTemp.Nombrecomercial = leer.ReadLine();
                localTemp.Actividad = leer.ReadLine();

                listLocal.Add(localTemp);
            }
            leer.Close();
            GridView5.DataSource = listLocal;
            GridView5.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\Pagos.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Pagos pagosTemp = new Pagos();
                pagosTemp.Descripcion = leer.ReadLine();
                pagosTemp.Idgasto = leer.ReadLine();
                pagosTemp.Importe = Convert.ToInt32(leer.ReadLine());
                pagosTemp.TipoReparto = leer.ReadLine();

                listPagos.Add(pagosTemp);
            }
            leer.Close();
            GridView6.DataSource = listPagos;
            GridView6.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\Piso.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Piso pisoTemp = new Piso();
                pisoTemp.Vhvn = leer.ReadLine();
                pisoTemp.Habitaciones = leer.ReadLine();

                listpiso.Add(pisoTemp);
            }
            leer.Close();
            GridView7.DataSource = listpiso;
            GridView7.DataBind();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string DirecArch = "C:\\Users\\RodericoEduardo\\Documents\\Universidad\\3\\Programación lll\\ProyectoFinal\\ProyectoFinal-1\\proyecto_final2\\Propiedad.txt";
            FileStream stream = new FileStream(DirecArch, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);

            while (leer.Peek() > -1)
            {
                Propiedad propiedadTemp = new Propiedad();
                propiedadTemp.Tipo = leer.ReadLine();
                propiedadTemp.Codigo = leer.ReadLine();
                propiedadTemp.MetrosCuadrados = Convert.ToInt32(leer.ReadLine());

                listPropiedad.Add(propiedadTemp);
            }
            leer.Close();
            GridView8.DataSource = listPropiedad;
            GridView8.DataBind();
        }
    }
}